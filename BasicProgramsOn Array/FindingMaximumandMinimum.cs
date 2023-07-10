using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramsOn_Array
{
    internal class FindingMaximumandMinimum
    {
        public static void MaxOrMin(int[] Array)
        {
            int max = Array[0];
            int min = Array[0];

            // find maximum and minimum elements
            for (int i = 1; i < Array.Length; i++)
            {
                if (Array[i] > max)
                {
                    max = Array[i];
                }
                if (Array[i] < min)
                {
                    min = Array[i];
                }
            }

            Console.WriteLine("Maximum element in the array: " + max);
            Console.WriteLine("Minimum element in the array: " + min);
        }
    }
}
