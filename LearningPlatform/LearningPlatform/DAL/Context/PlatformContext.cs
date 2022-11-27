using LearningPlatform.Model;
using Microsoft.EntityFrameworkCore;

namespace LearningPlatform.DAL.Context
{
    public class PlatformContext : DbContext
    {
        public PlatformContext(DbContextOptions<PlatformContext> opt) : base(opt)
        { }

        public DbSet<Platform> Platforms { get; set; }
    }
}
