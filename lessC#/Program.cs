using System;
using System.Diagnostics.Tracing;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lessC_
{
    
    internal class Program
    {
        
        static int Sum(int[,] arr2d)
        {
            int sum = 0;
            for (int j = 0; j < arr2d.GetLength(0); j++)
            {
                for (int k = 0; k < arr2d.GetLength(1); k++)
                {
                    sum += arr2d[j, k];
                }
            }
            return sum;
        }

        static int FindMin(int[,] arr2d)
        {
            int min = arr2d[0, 0]; 

            for (int i = 0; i < arr2d.GetLength(0); i++)
            {
                for (int j = 0; j < arr2d.GetLength(1); j++)
                {
                    if (arr2d[i, j] < min)
                    {
                        min = arr2d[i, j];
                    }
                }
            }

            return min;
        }

        static int CompareString(string login1, string login2) {
            return login1.ToUpper().CompareTo(login2.ToUpper());
            
        }
        static void Main(string[] args)
        {
            //Запитати у користувача рядок
            //Замінити всі сиимволи пробелов на знаки ?
            //Запитати користувача рядок логіна два рази, 
            //Написати метод порівняння рядків з урахуванням, що
            //alex Alex aLex ALEX це одне і теж саме


            Console.WriteLine("enter string");
            string text = Console.ReadLine();
            Console.WriteLine(text.Replace(' ', '?'));

            Console.WriteLine("enter login 1");
            string login1 = Console.ReadLine();

            Console.WriteLine("enter login2");
            string login2 = Console.ReadLine();
            //Console.WriteLine()


            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Enter num: ");
            int N;
            if (int.TryParse(Console.ReadLine(), out N))
            {
                Console.WriteLine($"Num: {N}");
            }
            else
            {
                Console.WriteLine("Error");
            }

            Console.Write("Enter num: ");
            int M;
            if (int.TryParse(Console.ReadLine(), out M))
            {
                Console.WriteLine($"{M}");
            }
            else
            {
                Console.WriteLine("Error");
            }

            int[,] arr2d = new int[N, M];
            for (int j = 0; j < arr2d.GetLength(0); j++)
            {
                for (int k = 0; k < arr2d.GetLength(1); k++)
                {
                    arr2d[j, k] = Random.Shared.Next(1, 10);
                    Console.Write($"{arr2d[j, k]} ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine(Sum(arr2d));
            Console.WriteLine(FindMin(arr2d));





        }
    }
}
