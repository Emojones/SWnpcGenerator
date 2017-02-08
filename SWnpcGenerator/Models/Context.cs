using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SWnpcGenerator.Models
{
    public class Context : DbContext
    {
        public Context() : base("SWnpcGenerator")
        {
        }

        public DbSet<Species> Specieses { get; set; }

        //overrides pluralizing of database names
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}