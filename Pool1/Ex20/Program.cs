using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex20
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = new int();
            int n = new int();

            Console.WriteLine("m/n");
            
            Console.Write("m= ");
            m.GetInt();

            Console.Write("n= ");
            do
            {
                n.GetInt();
            } while (n == 0);


            Console.WriteLine($"{m}/{n} = {DecimalFraction(m,n)}");
        }


        static string DecimalFraction(int numitor, int numarator)
        {
            string result;

            string wholePart = (numitor / numarator).ToString();
            string fractionalPart = ((float)numitor / numarator - int.Parse(wholePart)).ToString().Remove(0,2);


            List<int> digits = new List<int>();

            for (int i = 0; i < fractionalPart.Length; i++)
            {
                int currentDigit = int.Parse(fractionalPart[i].ToString());
                if (digits.Contains(currentDigit))
                {
                    fractionalPart = fractionalPart.Substring(0, i);

                    fractionalPart = fractionalPart.Insert(digits.IndexOf(currentDigit),"(");
                    fractionalPart = fractionalPart.Insert(fractionalPart.Length, ")");

                    break;
                }

                digits.Add(int.Parse(fractionalPart[i].ToString()));
            }

            
            result = wholePart + "." + fractionalPart;

            return result;
        }
    }
}
