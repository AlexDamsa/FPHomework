using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex22
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

            
            Reuniune(array, secondArray).Write();

            Intersectie(array, secondArray).Write();

            V1MinusV2(array, secondArray).Write();

            V1MinusV2(secondArray, array).Write();
        }

        static int[] Reuniune(int[] a, int[] b)
        {
            List<int> reunion = new List<int>();
            
            for (int i = 0; i < Math.Max(a.Length, b.Length); i++)
            {
                if (a.Length > i && !reunion.Contains(a[i]))
                {
                    reunion.Add(a[i]);
                }
                if (b.Length > i && !reunion.Contains(b[i]))
                {
                    reunion.Add(b[i]);
                }
            }

            return reunion.ToArray();
        }

        static int[] Intersectie(int[] a , int[] b)
        {
            List<int> intersection = new List<int>();

            if (b.Length > a.Length)
            {
                int[] temp = a;
                a = b;
                b = temp;
            }

            foreach (int x in a)
            {
                if (b.Contains(x))
                {
                    intersection.Add(x);
                }
            }

            return intersection.ToArray();
        }

        static int[] V1MinusV2(int[] a, int[] b)
        {
            List<int> aList = a.ToList<int>();
            List<int> bList = b.ToList<int>();

            foreach (int x in bList)
            {
                while (aList.Contains(x))
                {
                    aList.Remove(x);
                }
            }

            return aList.ToArray();
        }
    }
}
