param(
    [string]
    [Parameter(Mandatory=$true)]
    $Version
)

$baseFolder = "C:\src\prstat\WinPrStat"
$binFolder = "${baseFolder}\bin"
$webFolder = "C:\src\trinkle.in\www"
$publishFolder = (Select-String "PublishDir>(.*)</" ${baseFolder}\Properties\PublishProfiles\FolderProfile.pubxml).Matches.Groups[1].Value

$zipBasename = "WinPrStat"
$zipFilename = "${zipBasename}_v${Version}.zip"
$zipPath = "${binFolder}\${zipFilename}"

$versionJsonFile = "winprstat.latest.json"
$versionJsonPath = "$binFolder\$versionJsonFile"

$setupExeFilename = "setupWinPrStat_${Version}.exe"
$setupFolder = "${binFolder}\setup"
$setupExePath = "${setupFolder}\${setupExeFilename}"

function Delete-SetupFolderItems {
    Remove-Item "$setupFolder\*"
}

function Delete-PublishFolderItems {
    Write-Output "Deleting publish output files"
    
    Remove-Item -Force $zipPath
    Remove-Item -Recurse "$publishFolder\*"
    Get-ChildItem $publishFolder
}

function Delete-ZipFiles {
    Remove-Item "${binFolder}\${zipBasename}*.zip"
}

function Delete-JsonFile {
    Remove-Item $versionJsonPath
}

function Delete-DistributableFiles {
    Delete-PublishFolderItems
    Delete-SetupFolderItems
    Delete-ZipFiles
    Delete-JsonFile
}

function Execute-DotnetPublish {
    dotnet publish ${baseFolder}\WinPrStat.csproj /p:Configuration=Release /p:PublishProfile=FolderProfile
}

function Create-SetupExe {
    iscc /dVersion=$Version .\createInstaller.iss
}

function Create-ZipFile {
    7z a -r $zipPath $publishFolder
}

function Create-JsonFile {
    Write-Output "{`"Version`":`"${Version}`"}" > $versionJsonPath
}

function Copy-DistributableFilesToWebFolder {
    Copy-Item $zipPath $webFolder
    Copy-Item $setupExePath $webFolder
    Copy-Item $versionJsonPath $webFolder
}

function Generate-FileIntegrityTableMarkdown {
    $setupHash = ( Get-FileHash $setupExePath )
    $zipHash = ( Get-FileHash $zipPath )
    $filePaths = $setupExePath, $zipPath
    
    $tableMarkdown = "## File Integrity Hashes`n|  File | Algorithm | Hash |`n|-----|--------|------|`n"
    foreach ($fp in $filePaths) {
        $fileHash = Get-FileHash $fp
        $hash = $fileHash.Hash
        $file = Split-Path -leaf $fileHash.Path
        $alg = $fileHash.Algorithm
        $tableMarkdown += "| $file | $alg | $hash |`n"
    }

    Write-Output "File Integrity Table Markdown:"
    Write-Output $tableMarkdown
}

function Write-Step {
    param (
        $step
    )
    $pipe = "-----------------------------------------"
    Write-Output "`n$pipe`n$step`n$pipe"
}

Write-Step "Remove Old Distributable Files"
Delete-DistributableFiles
Write-Step "Run dotnet publish"
Execute-DotnetPublish
Write-Step "Create Distributable Files"
Create-ZipFile
Create-SetupExe
Create-JsonFile
Write-Step "Copy Distributables to Web Folder"
Copy-DistributableFilesToWebFolder
Write-Step "Generate File Integrity Table Markdown"
Generate-FileIntegrityTableMarkdown
