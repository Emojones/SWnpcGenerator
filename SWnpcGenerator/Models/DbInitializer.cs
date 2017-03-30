using System.Collections.Generic;
using System.Data.Entity;
using SWnpcGenerator.Models;

namespace SWnpcGenerator.Models
{
    internal class DbInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        //seed data for the database
        protected override void Seed(Context context)
        {

            var species1 = new Species()
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
            };
          context.Spp.Add(species1);

            var species2 = new Species()
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
            };
            context.Spp.Add(species2);

            var species3 = new Species()
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
            };
            context.Spp.Add(species3);

            var species4 = new Species()
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
            };
            context.Spp.Add(species4);

            var species5 = new Species()
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
            };
            context.Spp.Add(species5);

            var species6 = new Species()
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
            };
            context.Spp.Add(species6);

            var species7 = new Species()
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
            };
            context.Spp.Add(species7);

            var species8 = new Species()
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
            };
            context.Spp.Add(species8);

            var quirk1 = new Quirk()
            {
              QuirkList = "Is racist"
            };
            context.Quirks.Add(quirk1);

            var quirk2 = new Quirk()
            {
                QuirkList = "always eating something"
            };
            context.Quirks.Add(quirk2);

            var quirk3 = new Quirk()
            {
                QuirkList = "will not ever remember anyone's names except themselves"
            };
            context.Quirks.Add(quirk3);

            var quirk4 = new Quirk()
            {
                QuirkList = "constantly mispronouncing the most simple of words but has a great vocabulary"
            };
            context.Quirks.Add(quirk4);

            var quirk5 = new Quirk()
            {
                QuirkList = "if it's an ongoing interaction give the person a new profession every time. Either as a new job or just one of so many duties they are capable of doing"
            };
            context.Quirks.Add(quirk5);

            var quirk6 = new Quirk()
            {
                QuirkList = "Recovering cannibal"
            };
            context.Quirks.Add(quirk6);

            var quirk7 = new Quirk()
            {
                QuirkList = "Fear of droids"
            };
            context.Quirks.Add(quirk7);

            var quirk8 = new Quirk()
            {
                QuirkList = "Thinks they are in a VR game"
            };
            context.Quirks.Add(quirk8);

            var quirk9 = new Quirk()
            {
                QuirkList = "Overly pleasing"
            };
            context.Quirks.Add(quirk9);

            var quirk10 = new Quirk()
            {
                QuirkList = "Likes to take things apart"
            };
            context.Quirks.Add(quirk10);

            var quirk11 = new Quirk()
            {
                QuirkList = "Compulsively lies"
            };
            context.Quirks.Add(quirk11);

            var quirk12 = new Quirk()
            {
                QuirkList = "Split personality"
            };
            context.Quirks.Add(quirk12);

            var quirk13 = new Quirk()
            {
                QuirkList = "Loves bureaucracy"
            };
            context.Quirks.Add(quirk13);

            var quirk14 = new Quirk()
            {
                QuirkList = "Overweight"
            };
            context.Quirks.Add(quirk14);

            var quirk15 = new Quirk()
            {
                QuirkList = "Sickly looking"
            };
            context.Quirks.Add(quirk15);

            var quirk16 = new Quirk()
            {
                QuirkList = "Gambling addiction and is always flipping a coin to make decisions"
            };
            context.Quirks.Add(quirk16);

            var quirk17 = new Quirk()
            {
                QuirkList = "Talks like an over the top announcer"
            };
            context.Quirks.Add(quirk17);

            var quirk18 = new Quirk()
            {
                QuirkList = "Thinks they are lost royalty"
            };
            context.Quirks.Add(quirk18);

            var quirk19 = new Quirk()
            {
                QuirkList = "Only responds positively to polite conversation"
            };
            context.Quirks.Add(quirk19);

            var quirk20 = new Quirk()
            {
                QuirkList = "Fights for droid rights"
            };
            context.Quirks.Add(quirk20);

            var quirk21 = new Quirk()
            {
                QuirkList = "Conspiracy theorist"
            };
            context.Quirks.Add(quirk21);

            var quirk22 = new Quirk()
            {
                QuirkList = "Points out illegal actions but still does them"
            };
            context.Quirks.Add(quirk22);

            var quirk23 = new Quirk()
            {
                QuirkList = "Talks in third person"
            };
            context.Quirks.Add(quirk23);

            var quirk24 = new Quirk()
            {
                QuirkList = "Thinks they are from the past"
            };
            context.Quirks.Add(quirk24);

            var quirk25 = new Quirk()
            {
                QuirkList = "Is a cowboy"
            };
            context.Quirks.Add(quirk25);


            context.SaveChanges();
        }


    }
}