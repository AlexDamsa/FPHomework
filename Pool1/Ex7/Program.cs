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
            int a = new int();
            int b = new int();

            Console.Write("a= ");
            a.GetInt();

            Console.Write("b= ");
            b.GetInt();

            Swap(ref a, ref b);

            Console.WriteLine();

            Console.WriteLine($"a= {a}");
            Console.WriteLine($"b= {b}");
        }

        static void Swap(ref int a, ref int b)
        {
            int aux = a;
            a = b;
            b = aux;
        }
    }
}
