using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCHAMP
{
    static class EnumerableMethodsForConsole
    {
        public static void OutLineList<T>(this IEnumerable<T> collection, string prompt)
        {
            Console.WriteLine(prompt + ":\n" + string.Join("\n", collection));
        }
        public static void OutLine<T>(this IEnumerable<T> collection, string prompt)
        {
            Console.WriteLine(prompt + ":\t" + string.Join(",", collection));
        }
    }
}
