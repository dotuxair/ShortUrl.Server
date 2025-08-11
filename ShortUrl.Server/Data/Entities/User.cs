namespace ShortUrl.Server.Data.Entities
{
    public class User : BaseEntity
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string AvatarUrl { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public DateTimeOffset LastLoginAt { get; set; }
    }
}
