using Microsoft.EntityFrameworkCore;
using MVP.Core.Entities;
using MVP.Infraestructure.Data.Configuration;

namespace MVP.Infraestructure.Data
{
    public partial class MVPDBContext : DbContext
    {
        public MVPDBContext()
        {
        }

        public MVPDBContext(DbContextOptions<MVPDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }

    }
}
