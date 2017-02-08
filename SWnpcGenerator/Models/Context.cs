using System.Data.Entity;

namespace SWnpcGenerator
{
    public class Context : DbContext
    {
        public Context() : base("SWnpcGenerator")
        {
        }

        public DbSet<Species> Species { get; set; }

    }
}