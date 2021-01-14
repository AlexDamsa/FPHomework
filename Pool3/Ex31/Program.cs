using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex31
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

            int[] appearanceArray = new int[array.Max()+1];

            for (int i = 0; i < array.Length; i++)
            {
                appearanceArray[array[i]]++;
            }

            for (int i = 0; i < appearanceArray.Length; i++)
            {
                if (appearanceArray[i] > array.Length / 2)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine("nu exista");
        }
    }
}
