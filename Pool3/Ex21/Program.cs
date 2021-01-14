using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex21
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

            int careIPrimu = CareIPrimu(array, secondArray);

            if (careIPrimu == 1)
            {
                array.Write();
                secondArray.Write();
            }
            else if (careIPrimu == 2)
            {
                secondArray.Write();
                array.Write();
            }
            else
            {
                Console.WriteLine("sirurile sunt identice");
            }
        }

        public static int CareIPrimu(int[] array, int[] secondArray)
        {

            for (int i = 0; i < Math.Min(array.Length, secondArray.Length); i++)
            {
                if (array[i] < secondArray[i])
                {
                    return 1;
                }
                else if (array[i] > secondArray[i])
                {
                    return 2;
                }
            }

            if (array.Length > secondArray.Length)
            {
                return 2;
            }
            else if (array.Length < secondArray.Length)
            {
                return 1;
            }

            return 0;
        }
    }
}
