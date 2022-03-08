param(
    [string]
    [parameter(Mandatory=$true)]
    $Version
)

$baseFolder = "C:\src\prstat\WinPrStat"
$binFolder = "${baseFolder}\bin"
$webFolder = "C:\src\trinkle.in\www"
$zipBasename = "WinPrStat"
$versionJsonFile = "winprstat.latest.json"

function get-publish-folder {
    return (select-string "PublishDir>(.*)</" ${baseFolder}\Properties\PublishProfiles\FolderProfile.pubxml).Matches.Groups[1].Value
}

function get-zip-path {
    return "${binFolder}\${zipBasename}_v${Version}.zip"
}

function empty-setup-folder {
    $setupFolderPath = "${binFolder}\setup"
    Remove-Item $setupFolderPath\*
}

function empty-publish-folder {
    Write-Output "Clearing output files"
    $publishFolder = get-publish-folder
    $zipPath = get-zip-path
    Remove-Item -Force $zipPath
    Remove-Item -Recurse "$publishFolder\*"
    Get-ChildItem $publishFolder
}

function remove-zipfiles {
    Remove-Item "${binFolder}\${zipBasename}*.zip"
}

function remove-json {
    Remove-Item "${binFolder}\${versionJsonFile}"
}

function clean-publish-files {
    empty-publish-folder
    empty-setup-folder
    remove-zipfiles
    remove-json
}

function build-and-publish {
    dotnet publish ${baseFolder}\WinPrStat.csproj /p:Configuration=Release /p:PublishProfile=FolderProfile
}

function create-installer {
    iscc /dVersion=$Version .\createInstaller.iss
}

function create-zipfile {
    $publishFolder = get-publish-folder
    $zipPath = get-zip-path
    7z a -r $zipPath $publishFolder
}

function create-json {
    Write-Output "{`"Version`":`"${Version}`"}" > "${binFolder}\${versionJsonFile}"
}

function copy-files-to-webfolder {
    Copy-Item "${binFolder}\*.zip" $webFolder
    Copy-Item "${binFolder}\setup\*.exe" $webFolder
    Copy-Item "${binFolder}\$versionJsonFile" $webFolder
}

clean-publish-files
build-and-publish
create-zipfile
create-installer
create-json
copy-files-to-webfolder
