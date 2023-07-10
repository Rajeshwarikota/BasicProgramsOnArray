using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramsOn_Array
{
    internal class FrequencyOfEachElement
    {
        public static void Frequency()
        {
            Console.WriteLine("How many elents to add into array");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];
            Console.WriteLine("storing elements into array");

            for (int i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The frequency of each element in the array is:");
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        arr[j] = 0;
                    }
                }
                if (arr[i] != 0)
                {
                    Console.WriteLine(arr[i] + " occurs " + count + " times");
                }
            }

            Console.ReadLine();
        }
    }
}
