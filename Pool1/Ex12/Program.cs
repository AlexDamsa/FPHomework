using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = new int();
            int a = new int();
            int b = new int();

            int count = 0;

            Console.Write("n= ");
            n.GetInt();

            Console.Write("a= ");
            a.GetInt();

            Console.Write("b= ");
            b.GetInt();

            for (int i = 1; i <= b; i++)
            {
                if (i % n == 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"In intervalul [{a},{b}] exista {count} numere divizibile cu {n}");
        }
    }
}
