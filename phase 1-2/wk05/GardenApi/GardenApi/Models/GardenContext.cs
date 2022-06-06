using Microsoft.EntityFrameworkCore;

namespace GardenApi.Models
{
    public class GardenContext : DbContext
    {
        public GardenContext(DbContextOptions<GardenContext> options) :base(options)
        {
        }

        public DbSet<GardenItem> GardenItems { get; set; }
    }
}
