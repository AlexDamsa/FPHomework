using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex15
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int number = new int();

            int lastNumber = new int();

            bool firstTime = true;

            bool startDescending = false;
            bool bitonic = true;


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
                    firstTime = false;
                    Write.Arrow();
                    continue;
                }

                if (!bitonic)
                {
                    Write.Arrow();
                    continue;
                }

                if (lastNumber > number)
                {
                    startDescending = true;
                }

                if (lastNumber < number && startDescending)
                {
                    bitonic = false;
                }

                lastNumber = number;
                Write.Arrow();
            }

            if (bitonic)
            {
                Console.WriteLine("secventa este bitonica");
            }
            else
            {
                Console.WriteLine("secventa nu este bitonica");
            }
        }
    }
}
