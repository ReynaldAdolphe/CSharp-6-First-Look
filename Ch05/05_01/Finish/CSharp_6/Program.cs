using System;
using static System.Console;
using static System.Math;
using static CSharp_6.Writer;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Test_Debugging();
        }

        #region Debugging

        /// <summary>
        /// Improved Edit/Continue
        /// </summary>
        private static void Test_Debugging()
        {
            Artist d = new Artist();
            Console.WriteLine($"{d.Name}");

            var comics = new List<Comedian>() {
                new Comedian() {
                    Name = "Richard Pryor",
                    Age = 55,
                    FavoriteSeason = Season.Spring },
                new Comedian() {
                    Name = "Bob Hope",
                    Age = 76,
                    FavoriteSeason = Season.Summer }
                };

            var whoLovesSpring = from l in comics
                                 where l.FavoriteSeason == Season.Spring
                                 select l;                   
        }
    }

    internal class Comedian
    {
        public int Age { get; internal set; }
        public Season FavoriteSeason { get; internal set; }
        public string Name { get; internal set; }
    }

    enum Season
    {
        Spring,
        Summer
    }
}
    #endregion





