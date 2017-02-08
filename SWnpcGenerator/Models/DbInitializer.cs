using System.Collections.Generic;
using System.Data.Entity;

namespace SWnpcGenerator.Models
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            GetSpecies().ForEach(c => context.Specieses.Add(c));
        }

            private static List<Species> GetSpecies()
        {
            var species = new List<Species>
            {
            new Species
            {
                SpeciesName = "Droid",
                WoundThreshold = 10,
                StrainThreshold = 10,
                StartExp = 175,
                Brawn = 1,
                Agility = 1,
                Intellect = 1,
                Cunning = 1,
                Willpower = 1,
                Presence = 1
            },

                 new Species
                 {
                     SpeciesName = "Bothans",
                     WoundThreshold = 10,
                     StrainThreshold = 11,
                     StartExp = 100,
                     Brawn = 1,
                     Agility = 2,
                     Intellect = 2,
                     Willpower = 2,
                     Presence = 2
                 },

                  new Species
                  {
                      SpeciesName = "Duros",
                      WoundThreshold = 11,
                      StrainThreshold = 10,
                      StartExp = 100,
                      Brawn = 1,
                      Agility = 2,
                      Intellect = 3,
                      Cunning = 2,
                      Willpower = 2,
                      Presence = 2
                  },

                    new Species
                    {
                        SpeciesName = "Gran",
                        WoundThreshold = 10,
                        StrainThreshold = 9,
                        StartExp = 100,
                        Brawn = 2,
                        Agility = 2,
                        Intellect = 2,
                        Cunning = 1,
                        Willpower = 2,
                        Presence = 3
                    },

                      new Species
                      {
                          SpeciesName = "Humans",
                          WoundThreshold = 10,
                          StrainThreshold = 10,
                          StartExp = 110,
                          Brawn = 2,
                          Agility = 2,
                          Intellect = 2,
                          Cunning = 2,
                          Willpower = 2,
                          Presence = 2
                      },

                       new Species
                       {
                           SpeciesName = "Ithorians",
                           WoundThreshold = 9,
                           StrainThreshold = 12,
                           StartExp = 90,
                           Brawn = 2,
                           Agility = 1,
                           Intellect = 2,
                           Cunning = 2,
                           Willpower = 3,
                           Presence = 2
                       },

                   new Species
                   {
                       SpeciesName = "Mon Calamari",
                       WoundThreshold = 10,
                       StrainThreshold = 10,
                       StartExp = 100,
                       Brawn = 2,
                       Agility = 2,
                       Intellect = 3,
                       Cunning = 1,
                       Willpower = 2,
                       Presence = 2
                   },

                 new Species
                 {
                     SpeciesName = "Sullustan",
                     WoundThreshold = 10,
                     StrainThreshold = 10,
                     StartExp = 100,
                     Brawn = 2,
                     Agility = 3,
                     Intellect = 2,
                     Cunning = 1,
                     Willpower = 2,
                     Presence = 2
                 }
            };
            return species;
        }  


    }
}