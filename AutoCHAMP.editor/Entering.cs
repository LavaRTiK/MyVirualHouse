using System;

namespace AutoCHAMP
{
    static class Entering {

        public static double EnterDouble(string prompt) {
            Console.Write("\t{0}: ", prompt);
            string str = Console.ReadLine();
            return Convert.ToDouble(str);
        }

        public static ulong EnterUInt64(string prompt) {
            Console.Write("\t{0}: ", prompt);
            string str = Console.ReadLine();
            return ulong.Parse(str);
        }

        public static uint EnterUInt32InHex(string prompt) {
            Console.Write("\t{0}: ", prompt);
            string str = Console.ReadLine();
            return Convert.ToUInt32(str, 16);
        }
        public static string EnterString(string prompt)
        {
            Console.Write("\t{0}", prompt);
            string str = Console.ReadLine();
            return str;
        }
        public static int EnterInt32(string prompt)
        {
            Console.Write("\t {0}", prompt);
            string str = Console.ReadLine();
            return Convert.ToInt32(str);
        }
    }
}
