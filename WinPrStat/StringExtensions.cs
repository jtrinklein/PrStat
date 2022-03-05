using System.Linq;

namespace WinPrStat
{
    public static class StringExtensions
    {
        public static bool IsNewerVersionThan(this string mine, string testVersion)
        {
            var myParts = mine.Split('.').Select(x => int.Parse(x)).ToArray();
            var testParts = testVersion.Split('.').Select(x => int.Parse(x)).ToArray();
            return myParts[0] > testParts[0] || 
                (myParts[0] == testParts[0] && myParts[1] > testParts[1]) ||
                (myParts[0] == testParts[0] && myParts[1] == testParts[1] && myParts[2] > testParts[2]);
        }
    }
}
