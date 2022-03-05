namespace WinPrStatForm
{
    public static class IntegerExtensions
    {
        public static int HoursToMilliseconds(this int hours)
        {
            return (hours * 24 * 60).MinutesToMilliseconds();
        }
        public static int MinutesToMilliseconds(this int minutes)
        {
            return minutes * 60 * 1000;
        }
    }
}
