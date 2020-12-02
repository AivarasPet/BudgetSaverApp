using System;
using System.IO;

namespace BudgetSaverApp
{
    /// <summary>
    /// Allows reading a text file and saving its contents to a string array.
    /// </summary>
    class TextFileReader
    {
        /// <summary>
        /// Returns a string array from a text file.
        /// </summary>
        /// <param name="location">Directory of a file to be read</param>
        /// <returns></returns>
        public string[] FetchStringArrayByLocation(String location)
        {
            try
            {
                // Open the text file using a stream reader.
                using (var sr = new StreamReader(location))
                {
                    string[] arr = sr.ReadToEnd().Split('\n');
                    //Console.WriteLine(arr.Length);
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
