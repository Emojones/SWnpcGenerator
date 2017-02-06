using SWnpcGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SWnpcGenerator.Data
{
    public class SpeciesTestRepository
    {
        private static Species[] _species = new Species[]
            {
                new Species()
                {
                    Id = 1,
                    SpeciesName = "Droid",
                    WoundThreshold = 10,
                    StrainThreshold = 10,
                    StartExp = 175,
                    Stats = new Stats[]
                    {
                       new Stats() { Brawn = 1 },
                       new Stats() { Agility = 1 },
                       new Stats() { Intellect = 1 },
                       new Stats() { Cunning = 1 },
                       new Stats() { Willpower = 1 },
                       new Stats() { Presence = 1 }
                    }
                },

                 new Species()
                {
                    Id = 2,
                    SpeciesName = "Bothans",
                    WoundThreshold = 10,
                    StrainThreshold = 11,
                    StartExp = 100,
                    Stats = new Stats[]
                    {
                       new Stats() { Brawn = 1 },
                       new Stats() { Agility = 2 },
                       new Stats() { Intellect = 2 },
                       new Stats() { Cunning = 3 },
                       new Stats() { Willpower = 2 },
                       new Stats() { Presence = 2 }
                    }
                },

                  new Species()
                {
                    Id = 3,
                    SpeciesName = "Duros",
                    WoundThreshold = 11,
                    StrainThreshold = 10,
                    StartExp = 100,
                    Stats = new Stats[]
                    {
                       new Stats() { Brawn = 1 },
                       new Stats() { Agility = 2 },
                       new Stats() { Intellect = 3 },
                       new Stats() { Cunning = 2 },
                       new Stats() { Willpower = 2 },
                       new Stats() { Presence = 2 }                  
                    }
                },

                    new Species()
                {
                    Id = 4,
                    SpeciesName = "Gran",
                    WoundThreshold = 10,
                    StrainThreshold = 9,
                    StartExp = 100,
                    Stats = new Stats[]
                    {
                       new Stats() { Brawn = 2 },
                       new Stats() { Agility = 2 },
                       new Stats() { Intellect = 2 },
                       new Stats() { Cunning = 1 },
                       new Stats() { Willpower = 2 },
                       new Stats() { Presence = 3 }
                    }
                },

                      new Species()
                {
                    Id = 5,
                    SpeciesName = "Humans",
                    WoundThreshold = 10,
                    StrainThreshold = 10,
                    StartExp = 110,
                    Stats = new Stats[]
                    {
                       new Stats() { Brawn = 2 },
                       new Stats() { Agility = 2 },
                       new Stats() { Intellect = 2 },
                       new Stats() { Cunning = 2 },
                       new Stats() { Willpower = 2 },
                       new Stats() { Presence = 2 }
                    }
                },

                        new Species()
                {
                    Id = 6,
                    SpeciesName = "Ithorians",
                    WoundThreshold = 9,
                    StrainThreshold = 12,
                    StartExp = 90,
                    Stats = new Stats[]
                    {
                       new Stats() { Brawn = 2 },
                       new Stats() { Agility = 1 },
                       new Stats() { Intellect = 2 },
                       new Stats() { Cunning = 2 },
                       new Stats() { Willpower = 3 },
                       new Stats() { Presence = 2 }
                    }
                },

                   new Species()
                {
                    Id = 7,
                    SpeciesName = "Mon Calamari",
                    WoundThreshold = 10,
                    StrainThreshold = 10,
                    StartExp = 100,
                    Stats = new Stats[]
                    {
                       new Stats() { Brawn = 2 },
                       new Stats() { Agility = 2 },
                       new Stats() { Intellect = 3 },
                       new Stats() { Cunning = 1 },
                       new Stats() { Willpower = 2 },
                       new Stats() { Presence = 2 }
                    }
                },

                 new Species()
                {
                    Id = 8,
                    SpeciesName = "Sullustan",
                    WoundThreshold = 10,
                    StrainThreshold = 10,
                    StartExp = 100,
                    Stats = new Stats[]
                    {
                       new Stats() { Brawn = 2 },
                       new Stats() { Agility = 3 },
                       new Stats() { Intellect = 2 },
                       new Stats() { Cunning = 1 },
                       new Stats() { Willpower = 2 },
                       new Stats() { Presence = 2 }
                    }
                }



            };
    }
}