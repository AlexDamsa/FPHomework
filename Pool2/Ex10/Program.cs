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
            string input;
            int number = new int();

            int lastNumber = new int();
            bool firstTime = true;

            int count = 0;
            int max = 0;

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

                if (lastNumber == number)
                {
                    count++;
                }
                else
                {
                    if (max < count)
                    {
                        max = count + 1;
                    }

                    count = 0;
                }

                lastNumber = number;
                Write.Arrow();
            }

            Console.WriteLine(max);
        }
    }
}
