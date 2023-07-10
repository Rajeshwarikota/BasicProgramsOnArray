using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramsOn_Array
{
    class UniqueElements
    {
        public static void Elements()
        {
            Console.WriteLine("How many elents to add into array");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];
            Console.WriteLine("storing elements into array");

            for (int i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The unique elements in the array is:");
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    Console.WriteLine(arr[i] + " is a unique element.");
                }
            }

            Console.ReadLine();
        }
    }
}
