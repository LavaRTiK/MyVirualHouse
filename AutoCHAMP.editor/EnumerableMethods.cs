using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCHAMP
{
    static class EnumerableMethods
    {
        public static string ToLineList<T>(this IEnumerable<T> collection, string prompt)
        {
            return string.Concat(prompt, ":\n", string.Join("\n", collection), "\n");
        }
    }
}
