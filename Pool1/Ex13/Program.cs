using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;
using Ex4;
using Ex8;

namespace Ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            int y1 = new int();
            int y2 = new int();

            int count = 0;

            Console.Write("y1= ");
            y1.GetInt();

            Console.Write("y2= ");
            y2.GetInt();

            if (y1 > y2)
            {
                Ex8.Program.Swap(ref y1, ref y2);
            }

            for (int i = y1; i <= y2; i++)
            {
                if (Ex4.Program.LeapYear(i))
                {
                    count++;
                }
            }

            Console.WriteLine($"Intre anul {y1} si anul {y2} sunt {count} ani bisecti");
        }
    }
}
