using System;
using System.Text.RegularExpressions;

namespace Ex21
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int number = random.Next(1,1024);

            string input;

            Regex greather = new Regex(@"^>\d*$");
            Regex lower = new Regex(@"^<\d*$");
            Regex greatherOrEqual = new Regex(@"^>=\d*$");
            Regex lowerOrEqual = new Regex(@"^<=\d*$");
            Regex numberCheck = new Regex(@"^\d*$");

            Console.WriteLine("Comenzi:");
            Console.WriteLine(">val..................numrul este mai mare decat <val>?");
            Console.WriteLine("<val..................numrul este mai mic decat <val>?");
            Console.WriteLine(">=val.................numrul este mai mare sau egal cu <val>?");
            Console.WriteLine("<=val.................numrul este mai mic sau egal cu <val>?");
            Console.WriteLine("val...................incearca sa ghicesti");
            Console.WriteLine();



            int vall = new int();
            do
            {
                do
                {
                    Console.Write("->   ");
                    input = Console.ReadLine();

                    if (greather.IsMatch(input))
                    {
                        vall = int.Parse(input.Remove(0, 1));

                        if (number > vall)
                        {
                            Console.WriteLine("Da");
                        }
                        else
                        {
                            Console.WriteLine("Nu");
                        }

                        break;
                    }
                    else if (lower.IsMatch(input))
                    {
                        vall = int.Parse(input.Remove(0, 1));

                        if (number < vall)
                        {
                            Console.WriteLine("Da");
                        }
                        else
                        {
                            Console.WriteLine("Nu");
                        }

                        break;
                    }
                    else if (greatherOrEqual.IsMatch(input))
                    {
                        vall = int.Parse(input.Remove(0, 2));

                        if (number >= vall)
                        {
                            Console.WriteLine("Da");
                        }
                        else
                        {
                            Console.WriteLine("Nu");
                        }

                        break;
                    }
                    else if (lowerOrEqual.IsMatch(input))
                    {
                        vall = int.Parse(input.Remove(0, 2));

                        if (number <= vall)
                        {
                            Console.WriteLine("Da");
                        }
                        else
                        {
                            Console.WriteLine("Nu");
                        }

                        break;
                    }
                    else if (numberCheck.IsMatch(input))
                    {
                        vall = int.Parse(input);

                        if (vall == number)
                        {
                            #region Win Message
                            Console.WriteLine("───────────────────████");
                            Console.WriteLine("───────────────────█████");
                            Console.WriteLine("───────────────────██████");
                            Console.WriteLine("───────────────────███████");
                            Console.WriteLine("──────────────────████████");
                            Console.WriteLine("──────────────────████████");
                            Console.WriteLine("─────────────────█████████");
                            Console.WriteLine("────────────────█████████");
                            Console.WriteLine("───────────────█████████");
                            Console.WriteLine("──────────────█████████");
                            Console.WriteLine("──────────────██████████████████");
                            Console.WriteLine("────────────█████████████████████");
                            Console.WriteLine("───────────███████████████████████");
                            Console.WriteLine("████████─██████████████████████████");
                            Console.WriteLine("████████─███████████████████████████");
                            Console.WriteLine("████████─████████████████████████████");
                            Console.WriteLine("████████─████████████████████████████");
                            Console.WriteLine("████████─████████████████████████████");
                            Console.WriteLine("████████─████████████████████████████");
                            Console.WriteLine("████████─███████████████████████████");
                            Console.WriteLine("████████─██████████████████████████");
                            Console.WriteLine("████████─█████████████████████████");
                            Console.WriteLine("████████─████████████████████████");
                            Console.WriteLine("████████─███████████████████████");
                            #endregion
                        }
                        else
                        {
                            Console.WriteLine("Mai incearca");
                        }

                        break;
                    }
                } while (true);


            } while (!(numberCheck.IsMatch(input) && vall == number));
        }
    }
}
