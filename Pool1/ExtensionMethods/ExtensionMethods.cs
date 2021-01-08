using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class ExtensionMethods
    {
        public static bool GetInt (this ref int instance)
        {
            if (int.TryParse(Console.ReadLine(), out instance))
            {
                return true;
            }

            Console.Write("try again: ");
            return instance.GetInt();
        }

        public static int Lenght(this int instance)
        {
            if (instance != 0)
            {
                return 1 + (instance / 10).Lenght();
            }

            return 0;
        }

        public static void ReadOrStop(out string instance)
        {
            ConsoleKeyInfo key;
            
            string line = "";

            do
            {
                key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.Enter:
                        instance = line;
                        Console.WriteLine();
                        return;
                        break;
                    case ConsoleKey.Escape:
                        instance = null;
                        return;
                        break;
                    default:
                        line += key.KeyChar;
                        break;
                }
            } while (true);
        }
    }
}
