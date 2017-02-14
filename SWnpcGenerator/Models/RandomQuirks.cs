using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SWnpcGenerator.Models
{
    public class RandomQuirks
    {
        Context db = new Context();

        public object GetRandomQuirks()
        {
            var getRandomQuirks = db.Quirks
                    .OrderBy(c => Guid.NewGuid())
                    .FirstOrDefault();

            return getRandomQuirks;
        }
    }
}