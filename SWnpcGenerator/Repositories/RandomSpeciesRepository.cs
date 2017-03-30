using SWnpcGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SWnpcGenerator.Repositories
{
    //reorders items with GUID so it returns a new random row from the species db.
    public class RandomSpeciesRepository
    {
       public Species GetRandomSpecies()
        {
            using (var db = new Context())
            { 
                var getRandomSpecies = db.Spp
                    .OrderBy(c => Guid.NewGuid())
                    .FirstOrDefault();

            return getRandomSpecies;  
            }
        }
    }
}