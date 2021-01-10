using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public class Methods
    {
        public static bool ReadOrStop(out string str)
        {
            ConsoleKeyInfo key;
            string line = "";

            do
            {
                key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.Enter:
                        Console.WriteLine();
                        str = line;
                        return true;
                        break;

                    case ConsoleKey.Escape:
                        Console.WriteLine(" \b");

                        str = null;
                        return false;
                        break;

                    case ConsoleKey.Backspace:
                        Console.Write(" \b");
                        break;

                    default:
                        line += key.KeyChar;
                        break;
                }

            } while (!(key.Key == ConsoleKey.Enter || key.Key == ConsoleKey.Escape));

            str = null;
            throw new Exception("Something went wrong while reading input");
            return false;
        }
    }

    public class Write
    {
        public static void Arrow()
        {
            Console.Write("->   ");
        }

        public static void EscMessage()
        {
            Console.WriteLine("Apasa esc pentru a incheia secventa");
        }
    }
}
