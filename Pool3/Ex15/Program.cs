using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex15
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

            for (int i = 1; i < array.Length; i++)
            {
                if (array.Sequence(0, i).Contains(array[i]))
                {
                    Methods.RemoveFromArray(ref array, i);
                    i--;
                }
            }

            array.Write();
        }
    }
}
