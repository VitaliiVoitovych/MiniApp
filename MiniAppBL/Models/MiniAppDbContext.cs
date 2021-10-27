using System.Data.Entity;

namespace MiniAppBL.Models
{
    public class MiniAppDbContext : DbContext
    {
        public MiniAppDbContext() : base("DbConnection") { }

        public DbSet<ComponentType> ComponentType { get; set; }
        public DbSet<Component> Component { get; set; }
        public DbSet<Provider> Provider { get; set; }
        public DbSet<Storage> Storage { get; set; }
    }
}
