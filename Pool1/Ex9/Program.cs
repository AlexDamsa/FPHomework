using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = new int();

            Console.Write("number= ");
            n.GetInt();

            foreach (int x in Divisors(n))
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
        }

        static int[] Divisors(int n)
        {
            List<int> divisors = new List<int>();

            divisors.Add(1);

            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    divisors.Add(i);
                }
            }

            divisors.Add(n);

            return divisors.ToArray();
        }
    }
}
