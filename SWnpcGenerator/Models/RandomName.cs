using System;
using System.Collections.Generic;
using System.Linq;

namespace SWnpcGenerator
{
    public  class RandomName
    {
        //Assembles a random name based on the syllables
        private  Random _random = new Random();

        private  List<string> _firstSyllable = new List<string>
        {
            "Hur", "Rylo", "Ka", "Sul", "Hu", "Il", "Dr", "Bo", "Du", "Gr", "Mon"
        };
        private  List<string> _secondSyllable = new List<string>
        {
            "ma", "oi", "lu", "tha", "Cal", "ro", "", "'", "hori",
        };
        private List<string> _thirdSyllable = new List<string>
        {
            "Killian", "Thoris", "Syllus", "Bortan", "Skywalker", "Bodi"
        };


        public  string RandomFirstSyllable()
        {
            return _firstSyllable[_random.Next(0, _firstSyllable.Count-1)];
        }

        public  string RandomSecondSyllable()
        {
            return _secondSyllable[_random.Next(0, _secondSyllable.Count-1)];
        }

        public  string RandomThirdSyllable()
        {
            return _thirdSyllable[_random.Next(0, _thirdSyllable.Count-1)];
        }

       
       
        public string GenerateName()
        {
            string secondPart = " " + RandomThirdSyllable();
            string firstSyllable = RandomFirstSyllable();
            string secondSyllable = RandomSecondSyllable();            
            return string.Concat(string.Concat(firstSyllable, secondSyllable), secondPart);
        }

    }
}