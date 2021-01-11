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
            string input;
            int number = new int();

            int sum = 0;

            Write.EscMessage();

            Write.Arrow();
            while (Methods.ReadOrStop(out input))
            {
                if (!int.TryParse(input, out number))
                {
                    continue;
                }

                sum += Reverse(number);

                Write.Arrow();
            }

            Console.WriteLine($"sum = {sum}");
        }

        static int Reverse(int num)
        {
            int result = 0;

            while (num != 0)
            {
                result = result * 10 + num % 10;
                num /= 10;
            }

            return result;
        }
    }
}
