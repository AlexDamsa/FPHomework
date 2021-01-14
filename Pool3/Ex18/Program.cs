using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex18
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            Console.Write("polinom: ");
            input = Console.ReadLine();

            int n = new int();
            Console.Write("n= ");
            n.GetPositiveInt();

            int[] array = new int[n];
            array.FillArray();

            Console.Write("pozitie: ");
            n.GetNonNegativeInt();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'n')
                {
                    input = input.Remove(i, 1);
                    input = input.Insert(i, array[n].ToString());
                }
            }

            Console.WriteLine(input);
        }
    }
}
