using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = new int();

            Console.Write("number= ");
            n.GetInt();

            if (Prim(n))
            {
                Console.WriteLine($"Numarl {n} este prim");
            }
            else
            {
                Console.WriteLine($"Numarl {n} NU este prim");
            }
        }

        static bool Prim(int num)
        {
            if (num == 1 || num == 0)
            {
                return false;
            }

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
