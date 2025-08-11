using System.Numerics;

namespace ShortUrl.Server.Data.Entities
{
    public class Url
    {

        public BigInteger Id { get; set; }
        public string OriginalUrl { get; set; } = string.Empty;
        public string ShortUrl { get; set; } = string.Empty;

        public Guid UserId { get; set; }
        public User? User { get; set; }
    }
}
