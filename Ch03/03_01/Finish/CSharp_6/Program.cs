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
            Test_AsyncInCatchFinally();
        }

        #region New Language Features Part II - Statement Level

        /// <summary>
        /// Await in catch and finally blocks
        /// </summary>
        /// <returns></returns>
        private static async void Test_AsyncInCatchFinally()
        {
            // Old approach
            //Exception exception = null;
            //try
            //{
            //    throw new Exception("Something went wrong");
            //}
            //catch (Exception ex)
            //{
            //    exception = ex;
            //}
            //if (exception != null)
            //    await LogDataAsync("Problem description-->", exception);

            try
            {
                throw new Exception("Something went wrong");
            }
            catch (Exception ex)
            {
                await LogDataAsync("Problem description-->", ex);
            }
            finally {
                await LogDataAsync("Logging complete.", null);
            }            
        }

        private static async Task LogDataAsync(string details, Exception ex) {
            using (var thisFile = File.AppendText("issues.log"))
            {
                await thisFile.WriteLineAsync($"{details} {ex?.ToString()}");
            }
        }

        #endregion
    }


}
