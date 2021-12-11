using System;

namespace Pr_6_zad_2
{
    class Program
    {
        static int[] Input(int n)
        {
            Random rand = new Random();
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

        static void Change(int[] arr, int n)
        {
           
            int temp = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > temp)
                {
                    temp = arr[i];
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == temp)
                {
                    arr[i] = 0;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("введите размерность массива");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Одномерный массив:");
            int[] myArray = Input(n);
            Console.WriteLine("Исходный массив:");
            Print(myArray);
            Change(myArray,n);
            Console.WriteLine("Измененный массив:");
            Print(myArray);

        }
    }
}
