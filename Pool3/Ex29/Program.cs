using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex29
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = new int();
            Console.Write("n= ");
            n.GetPositiveInt();

            int[] arrray = new int[n];
            arrray.FillArray();

            arrray.MergeSort(0, arrray.Length-1);

            arrray.Write();
        }
    }
}
