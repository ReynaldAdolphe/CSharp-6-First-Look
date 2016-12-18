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
           // Test_AsyncInCatchFinally();

            Test_ExceptionFilters();
        }

        #region New Language Features Part II - Statement Level

        /// <summary>
        /// Await in catch and finally blocks
        /// </summary>
        private static async void Test_AsyncInCatchFinally()
        {
            try
            {
                throw new Exception("Something went wrong");
            }
            catch (Exception ex) 
            {
                await LogDataAsync("Problem description -->", ex);
            }
            finally
            {
                await LogDataAsync("Logging complete.", null);
            }
        }

        private static async Task LogDataAsync(string details, Exception ex)
        {
            using (var thisFile = File.AppendText("issues.log"))
            {
                await thisFile.WriteLineAsync($"{details} {ex?.ToString()}");
            }
        }

        /// <summary>
        /// Exception Filters
        /// </summary>
        private static async void Test_ExceptionFilters()
        {
            try
            {
                throw new Exception("Something went wrong");
            }
            catch (Exception ex) when (ex.Message.Substring(0,7)=="Warning")
            {
             // Just a warning - do nothing
            }
            catch (Exception ex) 
            {
                await LogDataAsync("Problem description -->", ex);
            }
            finally
            {
                await LogDataAsync("Logging complete.", null);
            }
        }

        #endregion
    }


}
