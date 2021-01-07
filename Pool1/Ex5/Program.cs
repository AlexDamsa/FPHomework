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
            int num = new int();
            int k = new int();

            Console.Write("number= ");
            num.GetInt();

            if (num.Lenght() == 1)
            {
                Console.WriteLine($"Numarul are o singura cifra: {num}");
                return;
            }

            do
            {
                Console.Write("k= ");
                k.GetInt();
            } while (k > num.Lenght() || k <= 0);


            /*while (k != 1)
            {
                num /= 10;
                k--;
            }*/

            int digit = (num / (int)Math.Pow(10, num.Lenght() - k)) % 10;

            Console.WriteLine(digit);
        }


    }
}
