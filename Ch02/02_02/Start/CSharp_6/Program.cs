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
            //  Test_NameOf();
        }

        #region New Language Features Part I - Expression Level 

        /// <summary>
        /// nameOf
        /// </summary>
        /// <param name="thePeople"></param>
        private static void Test_NameOf()
        {
            thePeople = null; 

            if (thePeople == null)
            {
                throw new ArgumentNullException("thePeople", "The parameter passed in is null.");
            };

            foreach (var name in thePeople)
            {
                Console.WriteLine(name);
                DateTime.Compare(DateTime.Today, DateTime.Today.AddDays(1));
            }
        }


        #endregion

    }
}
