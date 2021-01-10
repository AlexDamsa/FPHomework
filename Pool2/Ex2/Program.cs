using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = new int();
            string input;

            int negativeCount = 0;
            int positiveCount = 0;
            int count0 = 0;

            Console.WriteLine("Apasa esc pentru a incheia secventa");

            Console.Write("->   ");
            while (Methods.ReadOrStop(out input))
            {
                Console.Write("->   ");
                if (!int.TryParse(input, out number))
                {
                    continue;
                }

                if (number > 0)
                {
                    positiveCount++;
                }
                else if (number < 0)
                {
                    negativeCount++;
                }
                else
                {
                    count0++;
                }
            }

            Console.WriteLine($"pozitive: {positiveCount}");
            Console.WriteLine($"negative: {negativeCount}");
            Console.WriteLine($"0:        {count0}");
        }
    }
}
