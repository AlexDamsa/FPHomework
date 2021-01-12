using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = new int();

            Console.Write("n= ");
            n.GetPositiveInt();

            int[] array = new int[n];
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"array[{i}]= ");
                array[i].GetInt();
            }

            Console.Write("k= ");
            int k = new int();
            k.GetInt();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == k)
                {
                    index = i;
                    break;
                }
            }

            Console.WriteLine(index);
        }
    }
}
