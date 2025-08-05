using Microsoft.EntityFrameworkCore;

namespace ShortUrl.Server.Data
{
    public class ShortUrlDbContext(DbContextOptions<ShortUrlDbContext> options) : DbContext(options)
    {
    }
}
