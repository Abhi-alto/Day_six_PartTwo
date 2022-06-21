using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartTwo
{
    internal class Calculate
    {
        static int[] notes = new int[] { 2000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
        static int l = notes.Length;
        public static void chang(int n,int i)
        {
            int num_of_notes = n/notes[i];                              //gets number of notes
            if (num_of_notes > 0)
            {
                Console.WriteLine(num_of_notes + " note of " + notes[i]);
                if ((n - (num_of_notes * notes[i]))!=0)                  //exercises recursion if left change is not equal to zero
                {
                    chang((n - (num_of_notes * notes[i])), i + 1);
                }
            }
            else 
            {
                chang(n, i + 1);                                    //if current note is greater than the change left
            }
        }
    }
}
