using SWnpcGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SWnpcGenerator.Models
{
    public  class RandomSpecies
    {
        Context db = new Context();

        public object GetRandomSpecies()
        {
            var getRandomSpecies = db.Spp
                    .OrderBy(c => Guid.NewGuid())
                    .FirstOrDefault();

            return getRandomSpecies;
        }
    }
}