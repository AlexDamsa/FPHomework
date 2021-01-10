using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = null;
            int number = new int();
            int lastnumber = new int();

            bool ascending = true;
            bool firstTime = true;

            Write.EscMessage();

            //Write.Arrow();
            //number.GetInt();
            //lastnumber = number;

            Write.Arrow();
            while (Methods.ReadOrStop(out input))
            {
                if (!int.TryParse(input, out number))
                {
                    continue;
                }

                if (firstTime)
                {
                    lastnumber = number;
                    firstTime = false;
                }

                if (number < lastnumber)
                {
                    ascending = false;
                }

                lastnumber = number;

                Write.Arrow();
            }

            if (ascending)
            {
                Console.WriteLine("Secventa este crescatoare");
            }
            else
            {
                Console.WriteLine("Secventa NU este crescatoare");
            }
        }
    }
}
