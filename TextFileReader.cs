using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetSaverApp
{
    class TextFileReader
    {

        public  string[] FetchStringArrayByLocation(String location)
        {
            
            try
            {
                // Open the text file using a stream reader.
                using (var sr = new StreamReader(location))
                {
                    string[] arr = sr.ReadToEnd().Split('\n');
                    Console.WriteLine(arr.Length);
                    return arr;
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            return null;
        }
    }
}
