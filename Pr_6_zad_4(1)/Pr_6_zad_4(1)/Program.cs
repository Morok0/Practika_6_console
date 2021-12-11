using System;
using System.Linq;
using System.Numerics;


namespace Pr_6_zad_4_1_
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int n = 0, k;
            Console.WriteLine("\t Размер массивов:");
            k = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\t Введите количество массивов:");
            n = Int32.Parse(Console.ReadLine());
            int[][] a = new int[n][];
            for (int i = 0; i < n; i++)
                a[i] = new int[k];
            Console.WriteLine("\t Исходный массив:");

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < a[i].Length; ++j)

                    Console.WriteLine(a[i][j] = rnd.Next(0, 10));
                Console.WriteLine("\r\n");

            }

            Console.WriteLine("\t На что меняем?");
            int[] X = new int[k];
            for (int i = 0; i < k; i++)
            {
                X[i] = rnd.Next(0, 10);
                Console.Write(X[i] + "\n");

            }


            for (int i = 1; i < a.Length; i += 2)
            {
                a[i] = X;
            }
            Console.WriteLine("\t Изменённый массив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.WriteLine(a[i][j]);
                }
                Console.WriteLine("");
            }

        }
    }
}
