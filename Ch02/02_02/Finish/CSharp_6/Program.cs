using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_6
{
    class Program
    {
        private static List<string> theCrowd;        
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
            theCrowd = null;
            
            if (theCrowd == null)
            {
                throw new ArgumentNullException(nameof(theCrowd), "The parameter passed in is null.");
            };

            foreach (var name in theCrowd)
            {
                Console.WriteLine(name);
                DateTime.Compare(DateTime.Today, DateTime.Today.AddDays(1));
            }
        }


        #endregion

    }
}
