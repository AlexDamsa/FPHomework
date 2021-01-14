using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex25
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

            Console.Write("m= ");
            n.GetPositiveInt();

            int[] secondArray = new int[n];
            secondArray.FillArray();

            int[] thirdArray = new int[array.Length + secondArray.Length];

            int arrayIndex = 0;
            int secondArrayIndex = 0;
            int thirdArrayIndex = 0;



            while (arrayIndex < array.Length && secondArrayIndex < secondArray.Length)
            {
                if (array[arrayIndex] < secondArray[secondArrayIndex])
                {
                    thirdArray[thirdArrayIndex++] = array[arrayIndex++];
                }
                else
                {
                    thirdArray[thirdArrayIndex++] = secondArray[secondArrayIndex++];
                }
            }
            
            while (arrayIndex < array.Length)
            {
                thirdArray[thirdArrayIndex++] = array[arrayIndex++];
            }
            while (secondArrayIndex < secondArray.Length)
            {
                thirdArray[thirdArrayIndex++] = secondArray[secondArrayIndex++];
            }


            thirdArray.Write();
        }
    }
}
