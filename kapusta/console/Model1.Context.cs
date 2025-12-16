
namespace console
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class pr7Entities : DbContext
    {
        public pr7Entities()
            : base("name=pr7Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Parts> Parts { get; set; }
        public virtual DbSet<PartsInStock> PartsInStock { get; set; }
        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
