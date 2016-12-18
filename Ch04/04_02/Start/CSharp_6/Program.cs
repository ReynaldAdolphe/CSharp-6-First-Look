using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_6
{
    class Program
    {

        static void Main(string[] args)
        {
            //Test_AutoPropertyInitializers();
            Test_GetterOnlyAutoProperties();
        }

        #region New Language Features Part III - Member Declaration & Initializers

        /// <summary>
        /// Auto-Property Initializers
        /// </summary>
        private static void Test_AutoPropertyInitializers()
        {
            Artist d = new Artist();
            Console.WriteLine($"{d.Name}");
        }

        /// <summary>
        /// Getter Only Auto-Property Initializers
        /// </summary>
        private static void Test_GetterOnlyAutoProperties()
        {
            Artist d = new Artist();
            Console.WriteLine($"{d.Name}");
        }


        #endregion
    }


}
