using SWnpcGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SWnpcGenerator.Repositories
{
    public class RandomQuirksRepository
    {
        //reorders items with GUID so it returns a new random row from the quirks db.
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