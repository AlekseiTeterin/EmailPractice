namespace EmailPractice
{
    public class UTCTime : IClock
    {
        public DateTime GetUTCTime()
        {
            return TimeZoneInfo.ConvertTimeToUtc(DateTime.Now, TimeZoneInfo.Local);
        }
    }
}
