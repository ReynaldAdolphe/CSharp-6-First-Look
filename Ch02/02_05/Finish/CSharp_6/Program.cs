﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_6
{
    class Program
    {
        private static List<string> thePeople;
        static void Main(string[] args)
        {
            //string anArtist = "Elvis";

            //Test_NameOf(anArtist);

            //Test_StringInterpolation();

            //Test_NullConditionalOperators();

            Test_IndexInitiatlizer();
        }

        #region 2. New Language Features Part I - Expression Level 

        /// <summary>
        /// nameOf
        /// </summary>
        /// <param name=nameof(thePeople)></param>
        private static void Test_NameOf(string anArtist)
        {            
            thePeople = null; 
            
            if (thePeople == null)
            {
                throw new ArgumentNullException(nameof(anArtist), "The parameter passed in is null.");
            };

            foreach (var name in thePeople)
            {
                Console.WriteLine(name);
                DateTime.Compare(DateTime.Today, DateTime.Today.AddDays(1));
            }
        }

        /// <summary>
        /// String interpolation
        /// </summary>
        private static void Test_StringInterpolation()
        {
            var city = "Burbank";
            var state = "CA";
            var zip = 91505;
            decimal money = 15;

            var address_oldSchool = string.Format("334 S. Main St., {0},{1}", city, state);
            Console.WriteLine(address_oldSchool);

            var address_newSchool = $"334 S. Main St., {city}, {state},{zip}";
            Console.WriteLine(address_newSchool);

            var moneyOwed = $"Today: {DateTime.Now.ToShortDateString()}, Dollars owed: {money:C}";
            Console.WriteLine(moneyOwed);
        }

        /// <summary>
        /// Null-conditional operators
        /// </summary>        
        private static void Test_NullConditionalOperators()
        {

            //List<Artist> artists = null;
            List<Artist> artists = new List<Artist> {
                new Artist { Age = 103, Name = "Meryl Streep"},
                new Artist { Age = 5, Name = "Spot" }
            };

            // DEMO 1a
            //int? numberOFartists = (artists == null) ? (int?)null : artists.Count();  // Old approach
            int? numberOFartists = artists?.Count;                                      // New approach
            Console.WriteLine($"Total number of artists are: {numberOFartists}\n");

            // DEMO 1bs
            Artist defaultArtist = artists?[0];
            Console.WriteLine($"Default artist name is: {defaultArtist?.Name}\n");

            // DEMO 2 - null-coalescing operator
            int theCount = artists?.Count ?? 0;
            Console.WriteLine($"Artists count is: {theCount}\n");

            // DEMO 3 - chaining            
            Console.WriteLine($"Default artist, {defaultArtist?.Name}, is age: {artists?[0]?.Age}\n");            

        }

        /// <summary>
        /// Index initializers
        /// </summary>
        private static void Test_IndexInitiatlizer()
        {            
            // Old approach
            var myOldDictionary = new Dictionary<string, string>
            {
                { "Name", "Robert Deniro" },
                { "ArtistType", "Mafia" },
                { "FamousQuote", "Insulted him a little bit" }
            };

            var myNewDictionary = new Dictionary<string, string>
            {
                ["Name"] = "Robert Deniro",
                ["ArtistType"] = "Mafia",
                ["FamousQuote"] = "Insulted him a little bit"
            };

            var array = new[] { "Name", "ArtistType" };
            var thisArrayList = new List<string>(array)
            {
                [0] = "Robert DeNiro",
                [1] = "Mafia"
            };

            foreach (var item in thisArrayList)
            {
                Console.WriteLine(item);
            }



        }
        #endregion

    }


}
