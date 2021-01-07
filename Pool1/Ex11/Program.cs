using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = new int();

            Console.Write($"number= ");
            number.GetInt();

            while (number != 0)
            {
                Console.Write($"{number % 10} ");

                number /= 10;
            }

            Console.WriteLine();
        }
    }
}
