using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex19
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

            int m = new int();
            Console.Write("m= ");
            do
            {
                m.GetPositiveInt();
            } while (m > n);

            int[] secondArray = new int[m];
            secondArray.FillArray();

            int count = 0;

            for (int i = 0; i <= array.Length - secondArray.Length; i++)
            {
                if (IsSequence(i,array,secondArray))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }

        static bool IsSequence(int index, int[] originalArray, int[] sequence)
        {
            
            for (int i = 0; i < sequence.Length; i++)
            {
                if (originalArray[index] != sequence[i])
                {
                    return false;
                }

                index++;
            }

            return true;
        }
    }
}
