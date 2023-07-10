using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramsOn_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("....PROGRAMS ON ARRAY....");

            Console.WriteLine("\n:DuplicateElements\n2:UniqueElements\n22:Default");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("How many elents to add into array");
                    int n = Convert.ToInt32(Console.ReadLine());
                    int[] array = new int[n];
                    Console.WriteLine("storing elements into array");

                    for (int i = 0; i < n; i++)
                    {
                        array[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    CountOfDuplicateElements.Duplicate(array);
                    break;
                case 2:
                    UniqueElements.Elements();
                    break;
                default:
                    Console.WriteLine("Enter the correct option");
                    break;
            }
            Console.ReadLine();
        }
    }
}

