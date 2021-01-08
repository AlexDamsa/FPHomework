using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex17
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

            Console.WriteLine($"GCD: {GCD(a, b)}");
            Console.WriteLine($"LCM: {LCM(a, b)}");
        }

        public static int GCD(int a, int b)
        {
            while (a != b)
            {
                if (a < b)
                {
                    b -= a;
                }
                else
                {
                    a -= b;
                }
            }

            return a;
        }

        public static int LCM(int a, int b)
        {
            int originalA = a;
            int originalB = b;

            while (a != b)
            {
                if (a < b)
                {
                    a += originalA;
                }
                else
                {
                    b += originalB;
                }
            }

            return a;
        }
    }
}
