using SWnpcGenerator.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SWnpcGenerator.DAL
{
    public class Context : DbContext
    {
        public DbSet<Species> Speciess { get; set; }

    }
}