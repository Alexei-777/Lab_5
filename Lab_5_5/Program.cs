using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN следующего вида:
//1 0 1 0 1
//0 1 0 1 0
//1 0 1 0 1
//0 1 0 1 0
//1 0 1 0 1

namespace Lab_5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите глубину массива N)");
            //int N = 0;
            int N = Convert.ToInt32(Console.ReadLine());
            int a = N, b = N;
            int[,] array = new int[a,b];
            for (a = 0; a < N; a++)
            {
                for (b = 0; b < N; b++)
                    if ((a+b) % 2 > 0)
                    {
                        array[a, b] = 0;
                        Console.Write($" {array[a, b]}");
                    }
                    else
                    {
                        array[a, b] = 1;
                        Console.Write($" {array[a, b]}");
                    }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
