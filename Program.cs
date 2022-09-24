using System;

namespace Task_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrayA = new int[10, 10];
            Random rand = new Random();
            int minValue = 0;
            int maxValue = 10;
            int maxValueNumber = 0;
            Console.WriteLine("Массив с рандомными числами:");

            for (int i = 0; i < arrayA.GetLength(0); i++)
            {
                for (int j = 0; j < arrayA.GetLength(1); j++)
                {
                    arrayA[i, j] = rand.Next(minValue, maxValue);
                    Console.Write(arrayA[i, j] + " ");
                }

                Console.WriteLine();
            }

            foreach (int i in arrayA)
            {
                if (i > maxValueNumber)
                {
                    maxValueNumber = i;
                }
            }

            Console.WriteLine("\nНаибольшее число в массиве: " + maxValueNumber);
            Console.WriteLine("\nНовый массив: ");

            for (int i = 0; i < arrayA.GetLength(0); i++)
            {
                for (int j = 0; j < arrayA.GetLength(1); j++)
                {
                    if (arrayA[i, j] == maxValueNumber)
                    {
                        arrayA[i, j] = 0;
                    }
                    Console.Write(arrayA[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}