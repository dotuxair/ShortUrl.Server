using Microsoft.AspNetCore.Identity;

namespace ShortUrl.Server.Data.Entities
{
    public class ApplicationUser : IdentityUser<Guid>   // built in identity
    {
    }
}
