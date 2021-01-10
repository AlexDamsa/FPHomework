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
            
            int f1 = 0;
            int f2 = 1;
            int fn = 1;
            
            bool firstTime = true;
            
            Console.Write("n= ");
            do
            {
                n.GetInt();
            } while (n <= 0);
            
            
            switch (n)
            {
                case 1:
                    Console.WriteLine($"f{n} = {f1}");
                    break;
            
                case 2:
                    Console.WriteLine($"f{n} = {f2}");
                    break;
            
                case 3:
                    Console.WriteLine($"f{n} = {fn}");
                    break;
            
                default:
                    for (int i = 0; i < n - 3; i++)
                    {
                        //int temp = f2;
            
                        f1 = f2;
                        f2 = fn;
                        fn = f1 + f2;
                    }
                    Console.WriteLine($"f{n} = {fn}");
                    break;
            }
        }
    }
}
