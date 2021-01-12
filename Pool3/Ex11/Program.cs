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
            int n = new int();
            Console.Write("n= ");
            n.GetPositiveInt();

            for (int i = 2; i <= n; i++)
            {
                if (Prim(i))
                {
                    Console.Write($"{i} ");
                }
            }

            Console.WriteLine();
        }

        static bool Prim(int num)
        {
            if (num==1)
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
