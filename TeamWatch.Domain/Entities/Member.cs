namespace TeamWatch.Domain.Entities
{
    public class Member
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string TimeZone { get; set; }
        public double TimeZoneOffset { get; set; }

        public DateTime LocalCurrentTime
        {
            get
            {
                TimeZoneInfo timeZoneInfo = TimeZoneInfo.CreateCustomTimeZone($"{Name}'s Timezone", TimeSpan.FromHours(TimeZoneOffset), $"{Name}'s Local Timezone", $"{Name}'s Local Timezone");
                return TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, timeZoneInfo);
            }
        }


    }
}
