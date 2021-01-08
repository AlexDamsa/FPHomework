using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;
using Ex8;

namespace Ex16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = new int();
            int n2 = new int();
            int n3 = new int();
            int n4 = new int();
            int n5 = new int();

            Console.Write("n1= ");
            n1.GetInt();
            Console.Write("n2= ");
            n2.GetInt();
            Console.Write("n3= ");
            n3.GetInt();
            Console.Write("n4= ");
            n4.GetInt();
            Console.Write("n5= ");
            n5.GetInt();


            if (n1 > n2) { Ex8.Program.Swap(ref n1, ref n2); }
            if (n2 > n3) { Ex8.Program.Swap(ref n2, ref n3); }
            if (n3 > n4) { Ex8.Program.Swap(ref n3, ref n4); }
            if (n4 > n5) { Ex8.Program.Swap(ref n4, ref n5); }

            if (n1 > n2) { Ex8.Program.Swap(ref n1, ref n2); }
            if (n2 > n3) { Ex8.Program.Swap(ref n2, ref n3); }
            if (n3 > n4) { Ex8.Program.Swap(ref n3, ref n4); }

            if (n1 > n2) { Ex8.Program.Swap(ref n1, ref n2); }
            if (n2 > n3) { Ex8.Program.Swap(ref n2, ref n3); }

            if (n1 > n2) { Ex8.Program.Swap(ref n1, ref n2); }



            Console.WriteLine($"{n1} {n2} {n3} {n4} {n5}");
        }
    }
}
