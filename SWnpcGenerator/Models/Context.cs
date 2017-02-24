using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SWnpcGenerator.Models
{
    public class Context : DbContext
    {
        public Context() : base("SWnpcGenerator")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<Context>());
            Database.SetInitializer(new DbInitializer());
        }

        public DbSet<Species> Spp { get; set; }
        public DbSet<Quirk> Quirks { get; set; }
        public DbSet<PlaverSavedNpc> playerSaved { get; set; }      

        //overrides pluralizing of database names
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}