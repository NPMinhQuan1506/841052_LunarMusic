namespace ApplicationTier.API.Model
{
    public class CustAutho
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; } = null!;
        public DateTime? BirthDay { get; set; } = null!;
    }
}
