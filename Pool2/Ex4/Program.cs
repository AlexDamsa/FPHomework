using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int number = new int();
            int index = 0;
            int search = new int();
            int foundIndex = -1;

            Console.Write("Ce numar doresti sa cauti: ");
            search.GetInt();

            Console.WriteLine();

            Console.Write("->   ");
            while (Methods.ReadOrStop(out input))
            {
                Console.Write("->   ");
                if (!int.TryParse(input, out number))
                {
                    continue;
                }

                if(foundIndex != -1)
                {
                    continue;
                }

                if (number == search)
                {
                    foundIndex = index;
                }


                index++;
            }

            Console.WriteLine($"index: {foundIndex}");
        }
    }
}
