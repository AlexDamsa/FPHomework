using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;
using Ex23;

namespace Ex24
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


            //int[] binaryArray = BuildBinaryArray(array);
            //int[] secondBinaryArray = BuildBinaryArray(secondArray);

            Console.WriteLine("reuniunea: ");
            Reuniune(array, secondArray).Write();

            Console.WriteLine("intersectia: ");
            Intersectie(array, secondArray).Write();

            Console.WriteLine("v1-v2");
            V1MinusV2(array, secondArray).Write();

            Console.WriteLine("v2-v1");
            V1MinusV2(secondArray, array).Write();

            //Ex23.Program.V1MinusV2(array, secondArray).Write();
        }

        static int[] BuildBinaryArray(int[] array)
        {
            int[] finalArray = new int[array.Max()+1];

            foreach (int x in array)
            {
                finalArray[x] = 1;
            }

            return finalArray;
        }

        static int[] Reuniune(int[] a, int[] b)
        {
            return BuildBinaryArray(Ex23.Program.Reuniune(a,b));
        }

        static int[] Intersectie(int[] a, int[] b)
        {
            if (Ex23.Program.Intersectie(a, b).Length == 0)
            {
                return new int[] { 0};
            }

            return BuildBinaryArray(Ex23.Program.Intersectie(a, b));
        }

        static int[] V1MinusV2(int[] a, int[] b)
        {
            if (Ex23.Program.V1MinusV2(a, b).Length == 0)
            {
                return new int[] { 0};
            }

            return BuildBinaryArray(Ex23.Program.V1MinusV2(a, b));
        }
    }
}
