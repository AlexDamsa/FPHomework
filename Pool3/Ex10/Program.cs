using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex10
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
            k.GetInt();

            int index = array.BinarySearch(k);

            Console.WriteLine(index);
        }
    }
}
