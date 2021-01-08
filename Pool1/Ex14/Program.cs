using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = new int();

            Console.Write("n=");
            n.GetInt();

            if (Palindrom(n))
            {
                Console.WriteLine($"Numarul {n} este palindrom");
            }
            else
            {
                Console.WriteLine($"Numarul {n} NU este palindrom");
            }
        }

        public static bool Palindrom(int number)
        {
            if (number == 0 || number.Lenght() == 1)
            {
                return true;
            }

            int rightDigit;
            int leftDigit;

            for (int i = 0; i <= number.Lenght() / 2; i++)
            {
                leftDigit = (number / (int)Math.Pow(10, number.Lenght() - i - 1) % 10);
                rightDigit = (number / (int)Math.Pow(10, i) % 10);

                if (leftDigit != rightDigit)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
