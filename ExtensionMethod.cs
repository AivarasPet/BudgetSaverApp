using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetSaverApp
{
    static class ExtensionMethod
    {
        public static float Daily(this float f)
        {
            return (float)(Math.Truncate(100 * (f / 30)) / 100);
        }


    }
}
