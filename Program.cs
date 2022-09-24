using System;

namespace Task_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrayNumber = new int[10, 10];
            Random rand = new Random();
            int minValue = 0;
            int maxValue = 10;
            int maxValueNumber = 0;
            Console.WriteLine("Массив с рандомными числами:");

            for (int i = 0; i < arrayNumber.GetLength(0); i++)
            {
                for (int j = 0; j < arrayNumber.GetLength(1); j++)
                {
                    arrayNumber[i, j] = rand.Next(minValue, maxValue);
                    Console.Write(arrayNumber[i, j] + " ");
                }

                Console.WriteLine();
            }

            foreach (int symbol in arrayNumber)
            {
                if (symbol > maxValueNumber)
                {
                    maxValueNumber = symbol;
                }
            }

            Console.WriteLine("\nНаибольшее число в массиве: " + maxValueNumber);
            Console.WriteLine("\nНовый массив: ");

            for (int i = 0; i < arrayNumber.GetLength(0); i++)
            {
                for (int j = 0; j < arrayNumber.GetLength(1); j++)
                {
                    if (arrayNumber[i, j] == maxValueNumber)
                    {
                        arrayNumber[i, j] = 0;
                    }
                    Console.Write(arrayNumber[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}