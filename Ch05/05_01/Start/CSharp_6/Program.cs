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

        }

    }
    #endregion

}



