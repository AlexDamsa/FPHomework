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
            List<int> numbers = new List<int>();
            int input = new int();

            Console.Write("a= ");
            input.GetInt();
            numbers.Add(input);

            Console.Write("b= ");
            input.GetInt();
            numbers.Add(input);

            Console.Write("c= ");
            input.GetInt();
            numbers.Add(input);

            numbers.Sort();

            foreach (int x in numbers)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
        }
    }
}
