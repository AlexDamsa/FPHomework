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
            int n = new int();
            Console.Write("n= ");
            n.GetPositiveInt();

            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"array[{i}]= ");
                array[i].GetInt();
            }

            array.Reverse();

            array.Write();
        }
    }
}
