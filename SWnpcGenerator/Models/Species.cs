using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SWnpcGenerator.Models
{
    public class Species
    {
        public int Id { get; set; }
        [Required]
        public string SpeciesName { get; set; }
        [Required]
        public int WoundThreshold { get; set; }
        [Required]
        public int StrainThreshold { get; set; }
        [Required]
        public int StartExp { get; set; }
        [Required]
        public int Brawn { get; set; }
        [Required]
        public int Agility { get; set; }
        [Required]
        public int Intellect { get; set; }
        [Required]
        public int Cunning { get; set; }
        [Required]
        public int Willpower { get; set; }
        [Required]
        public int Presence { get; set; }
    }
}