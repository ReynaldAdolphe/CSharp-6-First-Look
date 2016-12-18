using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharp_6
{
    internal class Writer
    {
        public void StartTest(string statement)
        {
            WriteLine(statement);     // Will this call console.WriteLine or method below ?      
        }

        public void WriteLine(string statement)     
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

