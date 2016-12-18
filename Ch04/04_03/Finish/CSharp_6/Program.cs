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
            // Test_AutoPropertyInitializers();
            // Test_GetterOnlyAutoProperties();
            Test_ExpressionBodiedFunctionMembers();
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

        /// <summary>
        /// ExpressionBodied Function Members
        /// </summary>
        private static void Test_ExpressionBodiedFunctionMembers()
        {            
            // Old Approach
            Console.WriteLine(Name); // Example 1

            Console.WriteLine(GetFullName("Eddie", "Murphy")); // Example 2

            PrintFullName("Bill", "Murray"); // Example 3

            var c = PrintComedianName("Reynald", "Adolphe"); // Example 4
            Console.WriteLine(c.FirstName + " " + c.LastName); 
            
            
                     
        }

        // EBFM Example 1 - Property 
        static public string Name => "Jerry Seinfeld";

        // EBFM Example 2 - Method returning string        
        static public string GetFullName(string firstName, string lastName) => $"{firstName} {lastName}";

        // EBFM Example 3 - Method returning void      
        static public void PrintFullName(string firstName, string lastName) => Console.WriteLine($"{firstName} {lastName}");

        // EBFM Example 4 - Method returning object        
        static public Comedian PrintComedianName(string firstName, string lastName) => new Comedian(firstName, lastName);

        #endregion
    }


}
