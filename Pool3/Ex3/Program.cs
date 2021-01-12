using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex3
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

            int min = array[0];
            int max = array[0];
            List<int> minIndexes = new List<int>() { 0};
            List<int> maxIndexes = new List<int>() { 0};

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] <= min)
                {
                    if (array[i] == min)
                    {
                        minIndexes.Add(i);

                        continue;
                    }

                    minIndexes.Clear();
                    minIndexes.Add(i);

                    min = array[i];
                }
                else if(array[i] >= max)
                {
                    if (array[i] == max)
                    {
                        maxIndexes.Add(i);

                        continue;
                    }

                    maxIndexes.Clear();
                    maxIndexes.Add(i);

                    max = array[i];
                }
            }

            Console.Write($"min = {min}: ");
            foreach (int x in minIndexes)
            {
                Console.Write($"{x} ");
            }

            Console.WriteLine();

            Console.Write($"max = {max}: ");
            foreach (int x in maxIndexes)
            {
                Console.Write($"{x} ");
            }

            Console.WriteLine();
        }
    }
}
