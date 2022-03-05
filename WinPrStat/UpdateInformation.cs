namespace WinPrStat
{
    internal class UpdateInformation
    {
        public string Version { get; init; } = "0.0.0";
        public string Url { get; init; } = string.Empty;
        public bool NewerVersionAvailable { get; init; } = false;
    }
}
