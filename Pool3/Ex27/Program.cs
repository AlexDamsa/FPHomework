using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex27
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = new int();
            Console.Write("n= ");
            n.GetPositiveInt();

            int[] array = new int[n];
            array.FillArray();

            Console.Write("index= ");
            do
            {
                n.GetNonNegativeInt();
            } while (n >= array.Length);

            int[] sortedArray = array;
            sortedArray.SelectionSort();

            Console.WriteLine(sortedArray[n]);
        }
    }
}
