using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int produs = 1;

            int number = new int();

            Console.Write("number= ");
            number.GetInt();

            for (int i = 1; i <= number; i++)
            {
                suma += i;
                produs *= i;
            }

            Console.WriteLine($"suma:   {suma}");
            Console.WriteLine($"produs: {produs}");
        }
    }
}
