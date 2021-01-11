using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int number = new int();
            int lastNumber = new int();

            bool firstTime = true;

            int descendingCount = 0;
            int first = new int();


            Write.EscMessage();

            Write.Arrow();
            while (Methods.ReadOrStop(out input))
            {
                if (!int.TryParse(input, out number))
                {
                    continue;
                }
                if (firstTime)
                {
                    lastNumber = number;
                    first = number;
                    firstTime = false;
                    Write.Arrow();
                    continue;
                }

                if (lastNumber > number)
                {
                    descendingCount++;

                    if (first < number)
                    {
                        descendingCount += 2;
                    }
                }

                lastNumber = number;
                Write.Arrow();
            }

            if (descendingCount == 0)
            {
                Console.WriteLine("secventa este crescatoare");
            }
            else if (descendingCount == 1)
            {
                Console.WriteLine("secventa este crescatoare rotita");
            }
            else
            {
                Console.WriteLine("secventa nu este crescatoare rotita");
            }
        }
    }
}
