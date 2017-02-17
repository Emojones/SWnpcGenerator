using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SWnpcGenerator.Models
{
    public class RandomQuirks
    {
       public Quirk GetRandomQuirks()
        {
            using (var db = new Context())
            {
                var getRandomQuirks = db.Quirks
                    .OrderBy(c => Guid.NewGuid())
                    .FirstOrDefault();

                return getRandomQuirks;
            }
        }
    }
}