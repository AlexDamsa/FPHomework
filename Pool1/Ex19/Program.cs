using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex19
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = new int();
            List<int> digits = new List<int>();

            Console.Write("n= ");
            n.GetInt();

            if (NumberOfDistinctDigits(n) != 2)
            {
                Console.WriteLine("Numarul NU este format cu 2 cifre");
            }
            else
            {
                Console.WriteLine("Numarul este format cu 2 cifre");
            }
        }

        static int NumberOfDistinctDigits(int num)
        {
            List<int> digits = new List<int>();

            while (num != 0)
            {
                int lastDigit = num % 10;

                if (!digits.Contains(lastDigit))
                {
                    digits.Add(lastDigit);
                }

                num /= 10;
            }

            return digits.Count;
        }
    }
}
