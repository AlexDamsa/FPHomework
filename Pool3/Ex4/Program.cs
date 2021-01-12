using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = new int();
            Console.Write("n= ");
            n.GetPositiveInt();

            int min = int.MaxValue;
            int max = int.MinValue;

            int minCount = 0;
            int maxCount = 0;

            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"array[{i}]= ");
                array[i].GetInt();

                if (array[i] <= min)
                {
                    if (min == array[i])
                    {
                        minCount++;
                        continue;
                    }

                    min = array[i];
                    minCount = 1;
                }
                if (array[i] >= max)
                {
                    if (array[i] == max)
                    {
                        maxCount++;
                        continue;
                    }

                    max = array[i];
                    maxCount = 1;
                }
            }

            Console.WriteLine($"min = {min} : {minCount}");
            Console.WriteLine($"min = {max} : {maxCount}");
        }
    }
}
