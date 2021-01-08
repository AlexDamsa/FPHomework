using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex18
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = new int();

            Console.Write("n= ");
            n.GetInt();

            int divisor = 2;

            while (n != 1)
            {
                int exponent = 0;

                while (n % divisor == 0)
                {
                    exponent++;
                    n /= divisor;
                }

                if (exponent != 0)
                {
                    Console.Write($"{divisor}^{exponent} ");

                    if (n != 1)
                    {
                        Console.Write("* ");
                    }
                }

                divisor++;
            }

            Console.WriteLine();
        }
    }
}
