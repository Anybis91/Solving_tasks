using System;
using System.Linq;

namespace Task_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 3];
            Random rand = new Random();
            int minValue = 0;
            int maxValue = 10;
            int additionNumber = 0;
            int multiplicationNumber = 1;
            Console.WriteLine("Массив с рандомными числами:");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(minValue, maxValue);
                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }

            for (int j = 0; j < 3; j++)
            {
                additionNumber += array[1, j];
            }

            for (int i = 0; i < 3; i++)
            {
                multiplicationNumber *= array[i, 0];
            }

            Console.WriteLine("Сумма 2 строки = "+ additionNumber);
            Console.WriteLine("Произведение 1 столбца = " + multiplicationNumber);
        }
    }
}