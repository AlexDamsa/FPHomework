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
            int n = new int();
            Console.Write("n= ");
            n.GetNonNegativeInt();

            int b = new int();
            Console.Write("b= ");
            do
            {
                b.GetInt();
            } while (b<2 || b >16);

            ConvertBase(b, ref n);

            Console.WriteLine(n);
        }

        static void ConvertBase(int targetBase, ref int number)
        {
            List<int> newBase = new List<int>();

            while (number != 0)
            {
                int digit = number % targetBase;
                newBase.Add(digit);

                number /= targetBase;
            }

            int[] newBaseArray = newBase.ToArray();
            newBaseArray.Reverse();

            number = 0;
            foreach (int x in newBaseArray)
            {
                number = number * 10 + x;
            }
        }
    }
}
