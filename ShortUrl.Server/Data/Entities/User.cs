namespace ShortUrl.Server.Data.Entities
{
    public class User : BaseEntity
    {
        public Guid Id { get; set; }
        public required string Email { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public string? AvatarUrl { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset LastLoginAt { get; set; }
    }
}
