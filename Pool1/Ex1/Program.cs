using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Pool1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = new int();
            int b = new int();
            float x;

            #region Getting Input
            
            Console.Write("a= ");
            do
            {
                a.GetInt();
            } while (a == 0);

            Console.Write("b= ");
            b.GetInt();
            #endregion

            #region Processing

            x = (float)-b / a;
            #endregion

            #region Writing Output

            Console.WriteLine();
            Console.WriteLine($"{a}*x + {b} = 0");

            Console.WriteLine($"=> x = {x}");
            #endregion
        }
    }
}
