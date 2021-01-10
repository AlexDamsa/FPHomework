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
            int number = new int();
            string input;

            int count = 0;

            Console.WriteLine("Apasa esc pentru a incheia secventa");

            Console.Write("->   ");
            while (Methods.ReadOrStop(out input))
            {
                Console.Write("->   ");
                if (!int.TryParse(input, out number))
                {
                    //Console.WriteLine("try again");
                    continue;
                }

                if (number % 2 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"S-au citit {count} numere pare");
        }
    }
}
