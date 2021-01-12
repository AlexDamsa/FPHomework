using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex9
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

            int k = new int();
            Console.Write("k= ");
            k.GetPositiveInt();

            array.RotateLeft(k);

            array.Write();
        }
    }
}
