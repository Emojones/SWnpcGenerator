using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SWnpcGenerator.Models
{
    public class Species
    {
        public int Id { get; set; }
        public string SpeciesName { get; set; }
        public int WoundThreshold { get; set; }
        public int StrainThreshold { get; set; }
        public int StartExp { get; set; }
        public Stats[] Stats { get; set; } 

        //add species random selection
    }
}