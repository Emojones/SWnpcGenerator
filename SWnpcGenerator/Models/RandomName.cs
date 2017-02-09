using System;
using System.Collections.Generic;
using System.Linq;

namespace SWnpcGenerator
{
    public class RandomName
    {
        private static Random _random = new Random();

        private static List<string> _firstSyllable = new List<string>
        {
            "Hur", "Rylo", "Ka", "Sul", "Hu", "Il", "Dr", "Bo", "Du", "Gr", "Mon"
        };
        private static List<string> _secondSyllable = new List<string>
        {
            "ma", "oi", "lu", "tha", "Cal", "ro", "", "'", "hori",
        };
        private static List<string> _thirdSyllable = new List<string>
        {
            "Killian", "Thoris", "Syllus", "Bortan", "Skywalker", "Bodi"
        };


        public static string RandomFirstSyllable()
        {
            return _firstSyllable[_random.Next(0, _firstSyllable.Count)];
        }

        public static string RandomSecondSyllable()
        {
            return _secondSyllable[_random.Next(0, _firstSyllable.Count)];
        }

        public static string RandomThirdSyllable()
        {
            return _thirdSyllable[_random.Next(0, _firstSyllable.Count)];
        }

       
        string secondPart = " " + _thirdSyllable;
        public string GenerateName()
        {
            RandomFirstSyllable();
            RandomSecondSyllable();
            RandomThirdSyllable();
            return string.Concat(string.Concat(_firstSyllable, _secondSyllable), secondPart);
        }

    }
}