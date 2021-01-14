using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;
using Ex21;

namespace Ex26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstNumber = new int[0];
            int[] secondNumber = new int[0];

            Console.Write("first number =  ");
            ReadBigNumber(ref firstNumber);
            Console.Write("second number = ");
            ReadBigNumber(ref secondNumber);

            Console.Write("suma: ");
            WriteBigNumber(Suma(firstNumber, secondNumber));

            Console.Write("diferenta: ");
            WriteBigNumber(Diferenta(firstNumber, secondNumber).Item1, Diferenta(firstNumber, secondNumber).Item2);

            Console.Write("produs: ");
            WriteBigNumber(Produs(firstNumber, secondNumber));
            //
            //Produs(firstNumber, secondNumber).Write();

            Produs(firstNumber, secondNumber);
        }

        static void ReadBigNumber(ref int[] array)
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
                        return;

                    case ConsoleKey.Backspace:
                        Console.Write(" \b");
                        Array.Resize(ref array, array.Length - 1);
                        break;

                    default:
                        int digit;
                        if (int.TryParse(key.KeyChar.ToString(), out digit))
                        {
                            Array.Resize(ref array, array.Length + 1);
                            array[array.Length - 1] = digit;
                        }
                        else
                        {
                            Console.Write("\b \b");
                        }
                        break;
                }

            } while (!(key.Key == ConsoleKey.Enter));

            while (array[0] == 0)
            {
                Methods.RemoveFromArray(ref array, 0);
            }
        }
        static void WriteBigNumber(int [] array)
        {
            foreach (int x in array)
            {
                Console.Write(x);
            }
            Console.WriteLine();
        }
        static void WriteBigNumber(int[] array, bool negative)
        {
            if (negative)
            {
                Console.Write("-");
            }

            foreach (int x in array)
            {
                Console.Write(x);
            }
            Console.WriteLine();
        }

        static int[] Suma(int[] a, int[] b)
        {
            int[] sum = new int[0];

            if (a.Length < b.Length)
            {
                var temp = a;
                a = b;
                b = temp;
            }

            while (b.Length < a.Length)
            {
                Methods.InsertInArray(ref b, 0, 0);
            }

            int carry = 0;
            int digitSum;

            for (int i = a.Length - 1; i >= 0; i--)
            {
                //Console.WriteLine($"{a[i]} + {b[i]} % 10 + {carry} = {(a[i] + b[i]) % 10 + carry}");
                digitSum = (a[i] + b[i] + carry) % 10;

                //sum[i] = digitSum;
                Methods.InsertInArray(ref sum, digitSum, 0);

                carry = (a[i] + b[i] + carry) / 10;
            }

            if (carry != 0)
            {
                Methods.InsertInArray(ref sum, carry, 0);
            }

            return sum;
        }
        static (int[],bool) Diferenta(int[] a, int[] b)
        {
            int[] dif = new int[0];

            bool negative = false;

            if (CareIMaiMare(a, b) == 2/*Ex21.Program.CareIPrimu(a, b) == 1*/)
            {
                negative = true;

                var temp = a;
                a = b;
                b = temp;
            }
            
            while (b.Length < a.Length)
            {
                Methods.InsertInArray(ref b, 0, 0);
            }

            int digitDif;

            for (int i = a.Length - 1; i >= 0; i--)
            {
                if (a[i] < b[i])
                {
                    int index = i-1;
                    while (a[index] == 0)
                    {
                        index--;
                    }
                    a[index]--;
                    for (int j = index+1;i<i-1;i++)
                    {
                        a[i] = 9;
                    }

                    a[i] += 10;
                }

                digitDif = a[i] - b[i];

                Methods.InsertInArray(ref dif, digitDif, 0);
            }

            while (dif[0] == 0)
            {
                Methods.RemoveFromArray(ref dif, 0);
            }

            if (negative)
            {
                return (dif, true);
            }

            return (dif, false);

            int CareIMaiMare(int[] array1, int[] array2)
            {
                if (array1.Length < array2.Length)
                {
                    return 2;
                }
                else if (array1.Length > array2.Length)
                {
                    return 1;
                }

                for (int i = 0; i < Math.Min(array1.Length, array2.Length); i++)
                {
                    if (array1[i] < array2[i])
                    {
                        return 2;
                    }
                    else if (array1[i] > array2[i])
                    {
                        return 1;
                    }
                }

                return 0;
            }
        }
        static int[] Produs(int[] a, int[] b)
        {
            int[] prod = new int[0];
            
            //int zerAmount = 0;

            for (int i = b.Length - 1; i >= 0; i--)
            {
                int[] currentProd = ProdusVS(a, b[i]);

                //foreach (int x in currentProd)
                //{
                //    Console.Write(x);
                //}
                //Console.WriteLine();

                //for (int j = 0; j < zerAmount; j++)
                //{
                //    Methods.InsertInArray(ref currentProd, 0, currentProd.Length);
                //}
                //zerAmount++;

                for (int j = 0; j < b.Length - 1 - i; j++)
                {
                    Methods.InsertInArray(ref currentProd, 0, currentProd.Length);
                }
                //Console.Write($"current prod = ");
                //foreach (int x in currentProd)//
                //{
                //    Console.Write(x);
                //}
                //Console.WriteLine();


                prod = Suma(prod, currentProd);
            }

            return prod;

            int[] ProdusVS(int[] array, int number)
            {
                int[] prodVS = new int[0];

                int digitProd;

                int carry = 0;

                for (int i = array.Length - 1; i >= 0; i--)
                {
                    digitProd = (array[i] * number + carry) % 10;

                    Methods.InsertInArray(ref prodVS, digitProd, 0);

                    carry = (array[i] * number + carry) / 10;

                }

                if (carry != 0)
                {
                    Methods.InsertInArray(ref prodVS, carry, 0);
                }

                return prodVS;
            }
        }
    }
}
