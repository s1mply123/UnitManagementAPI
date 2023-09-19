using Microsoft.EntityFrameworkCore;

namespace UnitManagementAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Unit> Units => Set<Unit>();
        public DbSet<User> Users => Set<User>();
    }
}
