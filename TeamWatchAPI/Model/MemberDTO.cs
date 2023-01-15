namespace TeamWatchAPI.Model
{
    public class MemberDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string TimeZone { get; set; }
        public double TimeZoneOffset { get; set; }
    }
}
