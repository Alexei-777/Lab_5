using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2. Сформировать одномерный массив из 15 элементов, которые выбираются случайным образом из диапазона [0; 50]. Определить сумму максимального и минимального элементов массива.

namespace Lab_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 15;
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write($" Ячейка {i}, Значение {array[i]}");
                Console.WriteLine();
            }
            int max = array[0];
            int min = array[0];
            foreach (int a in array)
            {
                if (a > max)
                    max = a;
            }
            foreach (int b in array)
            {
                if (b < min)
                    min = b;
            }
            Console.WriteLine();
            Console.WriteLine($"Минимальное значение {min},Максимальное значение {max}, Сумма = {min+max}");
            Console.ReadKey();
        }
    }
}
