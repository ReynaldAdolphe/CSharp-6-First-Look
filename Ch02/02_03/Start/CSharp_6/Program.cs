using System;
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

            Test_StringInterpolation();
        }

        #region New Language Features Part I - Expression Level 

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

            var address_oldSchool = string.Format("\n334 S. Main St., {0}, {1}, {2}\n", city, state, zip);
            Console.WriteLine(address_oldSchool);

        }

        #endregion

    }
}
