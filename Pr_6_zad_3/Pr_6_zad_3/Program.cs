using System;

namespace Pr_6_zad_3
{
    class Program
    {
        static int[,] Input2(out int n)
        {
            Random rand = new Random();
            Console.WriteLine("введите размерность массива");
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            int[,] ar = new int[n,n];
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < n; ++j)
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
        static void Change2(int[,] ar, int n)
        {
            double sum = 0;
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(0); ++j)
                {
                    if (i + j == n - 1)
                    {
                        sum += ar[i, j];
                    }
                }
            }
            Console.Write("сумма ="+sum);
        }

        static void Main()
        {
            int n;
            int[,] myArray2 = Input2(out n);
            Console.WriteLine("Исходный массив:");
            Print2(myArray2);
            Change2(myArray2,n);
            
        }
    }
}

   
