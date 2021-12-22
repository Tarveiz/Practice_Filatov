using System;

namespace Kryuchkov_BSBO_03_18_Filatov_Pr_1
{
    class Program
    {
        static void Main()
        {
            Deri();
        }

        static void Deri()
        {
            Console.WriteLine("Введите количество строк: ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов: ");
            int cols = int.Parse(Console.ReadLine());
            int[,] arr = new int[rows, cols];

            Random r = new Random(); // объявление переменной для генерации случ. чисел
            Console.WriteLine();
            for (int i = 0; i < rows; i++) // массив заполнения случ. числами
            {
                Console.Write(i + ")");
                for (int j = 0; j < cols; j++)
                {
                    arr[i, j] = r.Next(2);
                    Console.Write("{0,3}", arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine(String.Join(" ", arr));


            int prevNum = -1;
            for (int i = 0; i < rows; i++)
            {
                prevNum = -1;
                for (int j = 0; j < cols; j++)
                {
                    if (cols == 1)
                    {
                        Console.WriteLine("Мало данных для выполнения задания. Пожалуйста увеличьте количество столбцов.");
                        return;
                    }
                    if (prevNum != arr[i, j])
                    {
                        prevNum = arr[i, j];
                    }
                    else break;
                    if (j == cols - 1)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
