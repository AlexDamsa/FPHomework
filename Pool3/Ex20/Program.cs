using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex20
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            int n = new int();
            Console.Write("n= ");
            n.GetPositiveInt();
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"firstArray[{i}]= ");
                do
                {
                    array[i].GetNonNegativeInt();
                } while (array[i]>=2);
            }
            int[] secondArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"secondArray[{i}]= ");
                do
                {
                    secondArray[i].GetNonNegativeInt();
                } while (secondArray[i] >= 2);

                if (array[i] == secondArray[i])
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
