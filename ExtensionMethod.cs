using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BudgetSaverApp
{
    static class ExtensionMethod
    {
        public static float Daily(this float f)
        {
            return (float)(Math.Truncate(100 * (f / 30)) / 100);
        }

        public static IList<T> Clone<T>(this IList<T> listToClone) where T : ICloneable
        {
            return listToClone.Select(item => (T)item.Clone()).ToList();
        }

        public static string ErrorMessageIfNotMatchesRegex(this string message, string regexKey, string source)
        {
            return Regex.IsMatch(source, regexKey) ? "" : message + '\n';
        }
    }
}
