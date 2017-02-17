using SWnpcGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SWnpcGenerator.Models
{

    public  class RandomSpecies
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