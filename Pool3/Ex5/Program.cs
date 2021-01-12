using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = new int();
            Console.Write("n= ");
            n.GetPositiveInt();

            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"array[{i}]= ");
                array[i].GetInt();
            }

            int e = new int();
            Console.Write("e= ");
            e.GetInt();

            int k = new int();
            Console.Write("k= ");
            do
            {
                if (k > array.Length)
                {
                    Console.Write("try again: ");
                }
                k.GetNonNegativeInt();
            } while (k > array.Length);

            Methods.InsertInArray(ref array, e, k);

            array.Write();
        }
    }
}
