using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharp_6
{
    static internal class Writer
    {
        static public void StartTest(string statement)
        {
            // Will this call console.writeline or method below ?
            WriteLine(statement);     
        }

        static public void WriteLine(string statement)     
        {
            Console.WriteLine("Instance method selected:" + statement);
        }

        public static int Compare(string first, string last)    
        {
            int r = string.Compare(first, last);
            return r;
        }
    }
}

