using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int[,] mas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };

            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mas[i, j]} \t");
                }
                Console.WriteLine();
            }

            int[][] numbers = new int[3][];
            numbers[0] = new int[] { 1, 2 };
            numbers[1] = new int[] { 1, 2, 3 };
            numbers[2] = new int[] { 1, 2, 3, 4};
            for (int z = 0; z < numbers.Length; z++)
            {
                for (int f = 0; f < numbers[z].Length; f++)
                {
                    Console.Write($"{numbers[z][f]} \t");
                }
                Console.WriteLine();
            }
            //d) 

            var a = new[] { 1, 10, 100, 1000 }; // int[] 

            var b = new[] { "Привет, ", "мир!" }; // string[]

            //разграничь номера комментариями
            //b) 

            Console.WriteLine("Введите размер массива");
            int n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];
            Console.WriteLine("Вводите элементы массива массива нажимая Enter");
            for (int t = 0; t < n; t++)
            {
                arr[t] = Console.ReadLine(); // заполнение массива 
            }
            Console.WriteLine("Массив: ");
            foreach (string s in arr) Console.Write(s + " "); // вывод массива 
            int length = arr.Length;
            Console.WriteLine(length);
            Console.ReadLine();
        }
    }
    }
    }
