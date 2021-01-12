using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = new int();
            Console.Write("n= ");
            n.GetPositiveInt();

            int lastIndex = n - 1;
            int currentIndex = 0;

            int[] araAra = new int[n];
            for (int i = 0; i <= lastIndex; i++)
            {
                Console.Write($"araAra[{currentIndex}]= ");
                araAra[i].GetInt();

                if (araAra[i] == 0)
                {
                    i--;
                    lastIndex--;
                }

                currentIndex++;
            }

            araAra.Write();
        }
    }
}
