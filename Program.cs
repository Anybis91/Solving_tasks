using System;
using System.Linq;

namespace Task_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 3];
            Random random = new Random();
            int minValue = 0;
            int maxValue = 10;
            int additionNumber = 0;
            int multiplicationNumber = 1;
            Console.WriteLine("Массив с рандомными числами:");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(minValue, maxValue);
                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }

            for (int j = 0; j < array.GetLength(0); j++)
            {
                additionNumber += array[1, j];
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                multiplicationNumber *= array[i, 0];
            }

            Console.WriteLine("Сумма второй строки массива = "+ additionNumber);
            Console.WriteLine("Произведение первого столбца массива = " + multiplicationNumber);
        }
    }
}