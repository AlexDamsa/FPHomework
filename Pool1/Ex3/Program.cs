using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = new int();
            int k = new int();

            Console.Write("n= ");
            n.GetInt();

            Console.Write("k= ");
            k.GetInt();

            if (n / k == (float)n / k)
            {
                Console.WriteLine("n se divide cu k");
            }
            else
            {
                Console.WriteLine("n NU se divide cu k");
            }
        }
    }
}
