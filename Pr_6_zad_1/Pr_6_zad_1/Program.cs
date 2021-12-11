using System;

namespace Pr_6_zad_1
{
    class Program
    {
        static int[] Input()
        {
            Random rand = new Random();
            Console.WriteLine("введите размерность массива");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; ++i)
            {
                arr[i] = rand.Next(-10, 10);
            }
            return arr;
        }

        static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; ++i) Console.Write("{0} ", arr[i]);
            Console.WriteLine();
        }

        static void Change(int[] arr)
        {
            Console.Write("Ввод a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Ввод b: ");
            int b = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= a && arr[i] <= b) arr[i] = 0;
            }
        }
        static int[,] Input2(out int n, out int m)
        {
            Random rand = new Random();
            Console.WriteLine("введите размерность массива");
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            m = int.Parse(Console.ReadLine());
            int[,] ar = new int[n, m];
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                {
                    ar[i, j] = rand.Next(-10, 10);
                }
            return ar;
        }
        static void Print2(int[,] ar)
        {
            for (int i = 0; i < ar.GetLength(0); i++, Console.WriteLine())
                for (int j = 0; j < ar.GetLength(1); j++)
                    Console.Write("{0,5} ", ar[i, j]);
        }
        static void Change2(int[,] ar)
        {
            Console.Write("Ввод a: "); 
            int a = int.Parse(Console.ReadLine());
            Console.Write("Ввод b: "); 
            int b = int.Parse(Console.ReadLine());
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(0); ++j)
                {
                    if (ar[i, j] >= a && ar[i, j] <= b) ar[i, j] = 0;
                }
            }



        }

        static void Main()
        {
            Console.WriteLine("Одномерный массив:");
            int[] myArray = Input();
            Console.WriteLine("Исходный массив:");
            Print(myArray);
            Change(myArray);
            Console.WriteLine("Измененный массив:");
            Print(myArray);
            Console.WriteLine("Двумерный. массив:");
            int n, m;
            int[,] myArray2 = Input2(out n, out m);
            Console.WriteLine("Исходный массив:");
            Print2(myArray2);
            Change2(myArray2);
            Console.WriteLine("Измененный массив:");
            Print2(myArray2);
        }
    }
}
