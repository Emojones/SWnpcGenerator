using SWnpcGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SWnpcGenerator.Models
{
    public class RandomNPC
    {
        
        public Species Species { get; set; }
        public Quirk Quirk { get; set; }
        public string RandomName { get; set; }
    }
}