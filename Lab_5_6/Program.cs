using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//6. Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN. Заполнить массив числами, вводимыми с клавиатуры.
//Проверить, является ли введенная с клавиатуры матрица магическим квадратом.
//Магическим квадратом называется матрица, сумма элементов которой в каждой строке, в каждом столбце и по каждой диагонали одинакова.
namespace Lab_5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите глубину массива N)");
            //int N = 0;
            int N = Convert.ToInt32(Console.ReadLine());
            int a = N, b = N;
            int[] X = new int[N];
            int[] Y = new int[N];
            int[] Z = new int[2];
            int[,] array = new int[a, b];
            for (a = 0; a < N; a++) //Ввод данны квадрата
            {
                for (b = 0; b < N; b++)
                {
                    Console.WriteLine($"Введите значение координаты {a}, {b}");
                    int t = Convert.ToInt32(Console.ReadLine());
                    array[a, b] = t;
                }
                Console.WriteLine();
            }

            for (a = 0; a < N; a++) // Заполняю матрицу суммами строки, столбцы 
            {
                for (b = 0; b < N; b++)
                {
                    X[a] = X[a] + array[a, b];
                    Y[b] = Y[b] + array[b, a];
                }
                Z[0] = Z[0] + array[a, a];    //Поиск сумм элементов главной и побочной диагонали
                Z[1] = Z[1] + array[N - 1 - a, a];
            }
            int x = 0, y = 0;// Сравнение
            for (a = 0; a < N; a++) 
            {
                x = x + X[a];
                y = y + Y[a];
                Console.WriteLine($"X{a}, {X[a]}");
                Console.WriteLine($"Y{a}, {Y[a]}");
            }
            Console.WriteLine($"Z1  {Z[0]}");
            Console.WriteLine($"Z1  {Z[1]}");
            if ((x/N)==(y/N) && (x / N) == Z[0] && (x / N) == Z[1] && (y / N) == Z[0] && (y / N) == Z[1])
            {
                Console.WriteLine("Cоответствуют услвиям магического квадрата");
            }
            else
            {
                Console.WriteLine("Не соответствуют услвиям магического квадрата");
            }
            
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
