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
            string input;
            int number = new int();
            int n1 = new int();
            int n2 = new int();

            int first = new int();

            int inputs = 0;

            int changes = 0;

            Write.EscMessage();

            Write.Arrow();
            while (Methods.ReadOrStop(out input))
            {
                if (!int.TryParse(input, out number))
                {
                    continue;
                }
                if (inputs < 2)
                {
                    if (inputs == 0)
                    {
                        first = number;
                        n2 = number;
                    }
                    if (inputs == 1)
                    {
                        n1 = n2;
                        n2 = number;
                    }
                    inputs++;
                    Write.Arrow();
                    continue;
                }
                if (changes > 2)
                {
                    Write.Arrow();
                    continue;
                }

                if ((n1 > n2 && n2 < number) || (n1 < n2 && n2 > number))
                {
                    changes++;
                }
                if (changes == 2 && first > number)
                {
                    changes += 3;
                }

                n1 = n2;
                n2 = number;
                Write.Arrow();
            }

            if (changes > 2)
            {
                Console.WriteLine("secventa nu este bitonica rotita");
            }
            else
            {
                Console.WriteLine("secventa este bitonica rotita");
            }
        }
    }
}
