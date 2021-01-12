using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int[] array = new int[0];


            Console.Write($"array[{array.Length}]= ");
            while (Methods.ReadOrStop(out input))
            {
                int number = new int();
                if (!int.TryParse(input, out number))
                {
                    continue;
                }

                Array.Resize(ref array, array.Length + 1);
                array[array.Length - 1] = number;
                
                Console.Write($"array[{array.Length}]= ");
            }

            Console.WriteLine($"sum = {array.Sum()}");

        }
    }
}
