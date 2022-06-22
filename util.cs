using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartTwo
{
    internal class Util
    {
         public static void date(int d, int m, int y)
        {
            int yy = y - ((14 - m) / 12);
            int x = yy + yy / 4 + yy / 100 + yy / 400;
            int mm = m + 12 * ((14 - m) / 12) - 2;
            int dd = (d + x + ( 31*mm / 12)) % 7;
            Console.WriteLine(dd);
        }
    }
}


