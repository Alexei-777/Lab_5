using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//4. Сформировать одномерный массив из 20 случайных чисел в диапазоне [-50;50]. Определить количество нечетных положительных элементов, стоящих на четных местах.
namespace Lab_5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите глубину массива (только четные положительные значения (20))");
            int n = Convert.ToInt32(Console.ReadLine());
            //int n = 20;
            int[] array = new int[n];
            int s = 0;
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write($" Ячейка {i}, Значение {array[i]}");
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                if (array[i] % 2 > 0 && array[i] > 0 && i % 2 > 0)  //нечетных положительных элементов, стоящих на четных местах
                {
                    s = s + 1;
                }
            }
            Console.Write($" Сумма {s}");
            Console.WriteLine();
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($" Ячейка {i}, Значение {array[i]}");
            //    Console.WriteLine();
            //}
            Console.ReadKey();

        }
    }
}
