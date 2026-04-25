using System.Timers;

namespace lessArr
{
    internal class Program
    {
        static void ShowArr(string text, int[] arr) { 
            Console.WriteLine(text+ " : ");
            for (int i = 0; i < arr.Length; i++) {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void IsEven(int[] arr) {
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] % 2 == 0) {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();
        }

        static void IsOdd(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    continue;
                }
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static int IsUnique(int[] arr) {
            int count = 0;
            for (int i = 0; i < arr.Length; i++) {
                int countOfElem = 0;
                for (int j = 0; j < arr.Length; j++) {
                    if (i==j) {
                        continue;
                    }
                    if (arr[i] == arr[j]) { 
                        countOfElem++;
                    }
                }
                if (countOfElem == 0) { 
                    count++;
                }
            }
            return count;
        }

        static int CountLessThan(int[] arr, int num)
        {
            int count = 0;
            foreach (int el in arr)
            {
                if (el < num)
                    count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            int[] arr = [1,2,3,4,5,6,7,8,9];
            int[] arr2 = new int[10];
            //foreach (var el in arr) { 
            //    Console.Write(el + " ");
            //}
            //Console.WriteLine(" ");
            //int[][] jugged = new int[2][];
            //jugged[0] = new int[8];
            //jugged[1] = new int[3];

            //foreach (int[] iteam in jugged) {
            //    foreach (int el in iteam) {
            //        Console.Write(el + " ");
            //    }
            //    Console.WriteLine();
            //}
            Console.Write("Enter num: ");
            int num = int.Parse(Console.ReadLine());
            IsEven(arr);
            IsOdd(arr);
            Console.WriteLine(IsUnique(arr));
            Console.WriteLine(CountLessThan(arr, num));

        }
    }
}
