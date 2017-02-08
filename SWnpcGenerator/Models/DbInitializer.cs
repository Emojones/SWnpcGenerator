using System.Collections.Generic;
using System.Data.Entity;

namespace SWnpcGenerator.Models
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<SwContext>
    {
        protected override void Seed(SwContext db)
        {
            GetSpecies().ForEach(c => db.Spp.Add(c));
            GetQuirks().ForEach(c => db.Quirks.Add(c));
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

        private static List<Quirk> GetQuirks()
        {
            var quirks = new List<Quirk>
            {
            new Quirk
                {QuirkList = "Is racist"},
            new Quirk
                {QuirkList = "always eating something" },
             new Quirk
                {QuirkList = "will not ever remember anyone's names except themselves" },
              new Quirk
                {QuirkList = "constantly mispronouncing the most simple of words but has a great vocabulary" },
               new Quirk
                {QuirkList = "if it's an ongoing interaction give the person a new profession every time. Either as a new job or just one of so many duties they are capable of doing" },
                new Quirk
                {QuirkList = "Recovering cannibal" },
                 new Quirk
                {QuirkList = "Fear of droids" },
                  new Quirk
                {QuirkList = "Thinks they are in a VR game" },
                   new Quirk
                {QuirkList = "Overly pleasing" },
                    new Quirk
                {QuirkList = "Likes to take things apart" },
                     new Quirk
                {QuirkList = "Compulsively lies" },
                      new Quirk
                {QuirkList = "Split personality" },
                       new Quirk
                {QuirkList = "Loves bureaucracy" },
                        new Quirk
                {QuirkList = "Overweight" },
                         new Quirk
                {QuirkList = "Sickly looking" },
                          new Quirk
                {QuirkList = "Gambling addiction and is always flipping a coin to make decisions" },
                           new Quirk
                {QuirkList = "Talks like an over the top announcer" },
                            new Quirk
                {QuirkList = "" },
                             new Quirk
                {QuirkList = "Thinks they are lost royalty" },
                              new Quirk
                {QuirkList = "Only responds positively to polite conversation" },
                               new Quirk
                {QuirkList = "Fights for droid rights" },
                                new Quirk
                {QuirkList = "Conspiracy theorist" },
                                 new Quirk
                {QuirkList = "Points out illegal actions but still does them" },
                                  new Quirk
                {QuirkList = "Talks in third person" },
                                   new Quirk
                {QuirkList = "Thinks they are from the past" },
                                    new Quirk
                {QuirkList = "Is a cowboy" }
            };
            return quirks;
        }

    }
}