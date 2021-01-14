using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex30
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = new int();
            Console.Write("n= ");
            n.GetPositiveInt();

            int[] E = new int[n];
            E.FillArray();

            Console.WriteLine();

            int[] W = new int[n];
            W.FillArray();

            SortareBicriteriala(ref E, ref W);

            Console.Write("E: ");
            E.Write();
            Console.Write("W: ");
            W.Write();
        }

        static void SortareBicriteriala(ref int[] array, ref int[] array2)
        {
            Sortare(ref array, ref array2, 0, array.Length, false);
            foreach (int x in array)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
            foreach (int x in array2)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();

            int firstNewNumberIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i-1] != array[i])
                {
                    Sortare(ref array2, ref array, firstNewNumberIndex, i, true);

                    firstNewNumberIndex = i;
                }
            }
            
            Sortare(ref array2, ref array, firstNewNumberIndex, array.Length, true);

            void Sortare(ref int[] arr1, ref int[] arr2, int startingIndex, int length, bool descnding)
            {
                for (int i = startingIndex; i < length; i++)
                {
                    for (int j = i + 1; j < length; j++)
                    {
                        if (arr1[i] > arr1[j] && !descnding)
                        {
                            var temp1 = arr1[i];
                            arr1[i] = arr1[j];
                            arr1[j] = temp1;

                            var temp2 = arr2[i];
                            arr2[i] = arr2[j];
                            arr2[j] = temp2;
                        }
                        else if (arr1[i] < arr1[j] && descnding)
                        {
                            var temp1 = arr1[i];
                            arr1[i] = arr1[j];
                            arr1[j] = temp1;

                            var temp2 = arr2[i];
                            arr2[i] = arr2[j];
                            arr2[j] = temp2;
                        }
                    }
                }
            }
        }
    }
}
