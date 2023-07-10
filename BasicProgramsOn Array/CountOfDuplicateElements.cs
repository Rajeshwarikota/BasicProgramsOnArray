using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramsOn_Array
{
    internal class CountOfDuplicateElements
    {
        public static void Duplicate(int[] Array)
        {
            int count = 0;

            for (int i = 0; i < Array.Length - 1; i++)
            {
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[i] == Array[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine("Number of Count:" + count);
        }
    }
}
