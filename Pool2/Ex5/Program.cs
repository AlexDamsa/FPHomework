using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int number = new int();

            int index = 0;
            int count = 0;

            Write.EscMessage();

            Write.Arrow();
            while (Methods.ReadOrStop(out input))
            {
                Write.Arrow();
                if (!int.TryParse(input, out number))
                {
                    continue;
                }

                if (number == index)
                {
                    count++;
                }

                index++;
            }

            Console.WriteLine(count);
        }
    }
}
