using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = new int();
            int b = new int();
            int c = new int();
            float x1;
            float x2;

            #region Getting Input

            Console.Write("a= ");
            do
            {
                a.GetInt();
            } while (a == 0);

            Console.Write("b= ");
            b.GetInt();

            Console.Write("c= ");
            c.GetInt();
            #endregion

            #region Processing

            int delta = (int)Math.Pow(b, 2) - 4 * a * c;

            x1 = (float)(-b + delta) / (2 * a);
            x2 = (float)(-b - delta) / (2 * a);
            #endregion

            #region Writing Output

            Console.WriteLine();
            Console.WriteLine($"{a}*x^2 + {b}*x + c = 0");

            Console.WriteLine($"=> x1 = {x1}");
            Console.WriteLine($"=> x2 = {x2}");
            #endregion
        }
    }
}
