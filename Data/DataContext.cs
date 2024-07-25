using DatingAppProj.Entity;
using Microsoft.EntityFrameworkCore;

namespace DatingAppProj.Data
{
    public class DataContext(DbContextOptions options):DbContext(options)
    {
        public DbSet<AppUser> Users { get; set; }
    }
}
