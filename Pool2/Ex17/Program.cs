using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex17
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int number = new int();

            bool correct = true;

            int brackets = 0;

            int max = 0;

            Write.EscMessage();

            Write.Arrow();
            while (Methods.ReadOrStop(out input))
            {
                if (!int.TryParse(input, out number))
                {
                    continue;
                }
                if (number != 0 && number != 1)
                {
                    continue;
                }

                if (!correct)
                {
                    Write.Arrow();
                    continue;
                }

                if (number == 0)
                {
                    brackets++;
                }
                if (number == 1)
                {
                    brackets--;
                }

                if (brackets > max)
                {
                    max = brackets;
                }

                if (brackets < 0)
                {
                    correct = false;
                }

                Write.Arrow();
            }


            if (correct)
            {
                Console.WriteLine($"corect: {max}");
            }
            else
            {
                Console.WriteLine("incorect");
            }
        }
    }
}
