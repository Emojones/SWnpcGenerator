using SWnpcGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SWnpcGenerator.Repositories
{
    public class PlayerRepository
    {
        public void save(PlaverSavedNpc playerSave)
        {
            using (var context = new Context())
            {
                context.Entry(playerSave).State = EntityState.Added;

                context.SaveChanges();
            }
        }

    }
}