using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex14
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
            int ascendingCount = 0;

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
                if (lastNumber < number)
                {
                    ascendingCount++;

                    if (first > number)
                    {
                        ascendingCount += 2;
                    }
                }

                lastNumber = number;
                Write.Arrow();
            }

            

            if (ascendingCount < 2)
            {
                if (ascendingCount == 0)
                {
                    Console.WriteLine("secventa este descrescatoare");
                }
                else
                {
                    Console.WriteLine("secventa este descrescatoare rotita");
                }
            }
            else if (descendingCount < 2)
            {
                if (descendingCount == 0)
                {
                    Console.WriteLine("secventa este crescatoare");
                }
                else
                {
                    Console.WriteLine("secventa este crescatoare rotita");
                }
            }
            else
            {
                Console.WriteLine("secventa nu este monotona rotita");
            }
        }
    }
}
