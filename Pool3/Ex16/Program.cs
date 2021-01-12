using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex16
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

            Console.WriteLine(CMMDC(array));
        }

        static int CMMDC(int[] array)
        {
            int previousCMMDC = CMMDCAlaSimplu(array[0], array[1]);
            for (int i = 2; i < array.Length; i++)
            {
                previousCMMDC = CMMDCAlaSimplu(previousCMMDC, array[i]);
            }

            return previousCMMDC;

            int CMMDCAlaSimplu(int a, int b)
            {
                while (a != b)
                {
                    if (a > b)
                    {
                        a -= b;
                    }
                    else
                    {
                        b -= a;
                    }
                }
                return a;
            }
        }
    }
}
