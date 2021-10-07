using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3. Сформировать одномерный массив из 10 случайных чисел в диапазоне [-50;50]. Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию.
namespace Lab_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите глубину массива (только четные положительные значения (10))");
            int n = Convert.ToInt32(Console.ReadLine());
            //int n = 10;
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write($" Ячейка {i}, Значение {array[i]}");
                Console.WriteLine();
            }
            for (int i = 0; i < (n / 2); i++)
            {
                for (int j = i + 1; j < (n / 2); j++)
                    if (array[i] > array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
            }
            for (int i = n / 2; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                    if (array[i] < array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
            }
            Console.WriteLine();
            Console.WriteLine($"Первая половина элементов упорядочены по возрастанию, вторая по убыванию.");
            for (int i = 0; i < n; i++)
            {
                Console.Write($" Ячейка {i}, Значение {array[i]}");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
