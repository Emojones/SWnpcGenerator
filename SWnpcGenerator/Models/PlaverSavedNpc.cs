using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SWnpcGenerator.Models
{
    public class PlaverSavedNpc 
    {
        public PlaverSavedNpc()
        {
                
        }

        public PlaverSavedNpc(RandomNPC randomNpc)
        {            
            this.PlayerName = randomNpc.RandomName;
            this.SpeciesName = randomNpc.Species.SpeciesName;
            this.WoundThreshold = randomNpc.Species.WoundThreshold;
            this.StrainThreshold = randomNpc.Species.StrainThreshold;
            this.StartExp = randomNpc.Species.StartExp;
            this.Brawn = randomNpc.Species.Brawn;
            this.Agility = randomNpc.Species.Agility;
            this.Intellect = randomNpc.Species.Intellect;
            this.Cunning = randomNpc.Species.Cunning;
            this.Willpower = randomNpc.Species.Willpower;
            this.Presence = randomNpc.Species.Presence;
            this.QuirkList = randomNpc.Quirk.QuirkList;
        }

        [Key]
        public int PlayerSavedId { get; set; }
        public string PlayerName { get; set; }
        public string SpeciesName { get; set; }
        public int WoundThreshold { get; set; }
        public int StrainThreshold { get; set; }
        public int StartExp { get; set; }
        public int Brawn { get; set; }
        public int Agility { get; set; }
        public int Intellect { get; set; }
        public int Cunning { get; set; }
        public int Willpower { get; set; }
        public int Presence { get; set; }
        public string QuirkList { get; set; }
    }
}