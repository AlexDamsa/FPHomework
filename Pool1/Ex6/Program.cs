using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = new int();
            int b = new int();
            int c = new int();

            Console.Write("a= ");
            ReadPositiveNumber(ref a);
            Console.Write("b= ");
            ReadPositiveNumber(ref b);
            Console.Write("c= ");
            ReadPositiveNumber(ref c);

            if ((a < b + c) && (b < a + c) && (c < a + b))
            {
                Console.WriteLine($"{a}, {b} si {c} pot fi lungimile laturilor unui triunghi");
            }
            else
            {
                Console.WriteLine($"{a}, {b} si {c} NU pot fi lungimile laturilor unui triunghi");
            }
        }

        static void ReadPositiveNumber(ref int number)
        {
            do
            {
                number.GetInt();
            } while (number <= 0);
        }
    }
}
