using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1. Сформировать одномерный массив из 7 элементов. Заполнить массив числами, вводимыми с клавиатуры, определить среднее арифметическое элементов.
namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            int[] array = new int[n];
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите начение {i} массива ");
                array[i] = Convert.ToInt32(Console.ReadLine());
                s += array[i];
            }
            Console.WriteLine($"Среднее арехметическое значение = {s/n}");
            Console.ReadKey();
        }
    }
}
