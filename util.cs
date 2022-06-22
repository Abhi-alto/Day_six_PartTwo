using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartTwo
{
    internal class Util
    {
        public static void sqrt(double c)
        {
            double t=c;
            double epsilon= 1e-15;
            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = (t + (c / t)) / 2;
            }
            Console.WriteLine("Square root of "+c+" is " + t);
        }
    }
}


