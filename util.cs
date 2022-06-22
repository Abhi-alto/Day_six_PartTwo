using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartTwo
{
    internal class Util
    {
        public static void tobin(int n)
        {
            String bin = "";
            Console.Write("Binary of " + n + " is ");
            while (n>0)
            {
                bin = n % 2 + bin;
                n = n / 2;
            }
           
            Console.Write(bin);
        }
    }
}


