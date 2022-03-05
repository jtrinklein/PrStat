using System;

namespace WinPrStat
{
    public static class VersionExtensions
    {
        public static string SemverString(this Version version)
        {
            return version.ToString(3);
        }
        public static string SemverStringOrZeros(this Version version)
        {
            return version?.SemverString() ?? "0.0.0";
        }
    }
}
