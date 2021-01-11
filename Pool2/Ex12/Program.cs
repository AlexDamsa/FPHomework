using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int number = new int();
            int lastNumber = new int();

            int count = 0;

            bool firstTime = true;

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

                if (number == 0 && lastNumber != 0)
                {
                    count++;
                }

                lastNumber = number;
                Write.Arrow();
            }

            if (number != 0)
            {
                count++;
            }

            Console.WriteLine(count);
        }
    }
}
