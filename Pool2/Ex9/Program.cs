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
            string input;
            int number = new int();

            int count = 0;

            int lastNumber = new int();

            bool firstTime = true;

            bool crescator = true;
            bool descrescator = true;
            bool strict = true;

            Write.EscMessage();

            do
            {
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
                        firstTime = false;
                        Write.Arrow();
                        continue;
                    }

                    if (lastNumber > number)
                    {
                        crescator = false;
                    }
                    if (lastNumber < number)
                    {
                        descrescator = false;
                    }
                    if (lastNumber == number)
                    {
                        strict = false;
                    }

                    count++;
                    lastNumber = number;
                    Write.Arrow();
                }

                if (count >= 2)
                {
                    break;
                }

                Console.WriteLine();
                Console.WriteLine("introduceti cel putin 2 numere");
                Console.WriteLine();

            } while (count < 2);


            if (!crescator && !descrescator)
            {
                Console.WriteLine("secventa nu este monotona");
            }
            else
            {
                if (crescator)
                {
                    if (strict)
                    {
                        Console.WriteLine("secventa este strict crescatoare");
                    }
                    else
                    {
                        Console.WriteLine("secventa este crescatoare");
                    }
                }
                if (descrescator)
                {
                    if (strict)
                    {
                        Console.WriteLine("secventa este strict descrescatoare");
                    }
                    else
                    {
                        Console.WriteLine("secventa este descrescatoare");
                    }
                }
            }
        }
    }
}
