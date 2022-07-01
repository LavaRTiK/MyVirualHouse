using System;

namespace AutoCHAMP
{
    static class Displaying {
        public static void OutAsDecHexBin(ulong value, string prompt) {
            string sBin = Convert.ToString(unchecked((long)value), 2);
            sBin = new string('0', 64 - sBin.Length) + sBin;
            Console.WriteLine("{0,-15}{1:D20} 0x{1:X16}\n\t{2}b", 
                prompt, value, sBin);
        }
        
        public static void OutAsDecHexBin(uint value, string prompt) {
            string sBin = Convert.ToString(value, 2);
            sBin = new string('0', 32 - sBin.Length) + sBin;
            Console.WriteLine("{0,-45}{1:D10} 0x{1:X8}\n\t{2}b", 
                prompt, value, sBin);
        }
    }
}
