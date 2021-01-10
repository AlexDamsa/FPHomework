using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int number = new int();

            int min = int.MaxValue;
            int max = int.MinValue;

            Write.EscMessage();

            Write.Arrow();
            while (Methods.ReadOrStop(out input))
            {
                if (!int.TryParse(input, out number))
                {
                    continue;
                }

                if (number > max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min = number;
                }

                Write.Arrow();
            }

            Console.WriteLine($"min: {min}");
            Console.WriteLine($"min: {max}");
        }
    }
}
