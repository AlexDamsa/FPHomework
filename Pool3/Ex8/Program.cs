using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex8
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

            array.RotateLeft();

            array.Write();
        }
    }
}
