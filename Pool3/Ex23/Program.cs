using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;
using Ex22;

namespace Ex23
{
    public class Program
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

            Reuniune(array, secondArray).Write();

            Intersectie(array, secondArray).Write();

            V1MinusV2(array, secondArray).Write();

            V1MinusV2(secondArray, array).Write();
        }

        public static int[] Reuniune(int[] a, int[] b)
        {
            int[] reunion = Ex22.Program.Reuniune(a,b);
            reunion.SelectionSort();
            return reunion;
        }

        public static int[] Intersectie(int[] a, int[] b)
        {
            int[] intersection = Ex22.Program.Intersectie(a, b);
            intersection.SelectionSort();
            return intersection;
        }

        public static int[] V1MinusV2(int[] a, int[] b)
        {
            int[] aMinusB = Ex22.Program.V1MinusV2(a, b);
            aMinusB.SelectionSort();
            return aMinusB;
        }
    }
}
