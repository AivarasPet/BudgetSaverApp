using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetSaverApp
{
    class TextFileReader
    {

        public string[] FetchStringArrayByLocation(String location)
        {
            try
            {
               return System.IO.File.ReadAllLines(location);
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
