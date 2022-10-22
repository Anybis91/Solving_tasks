using System;

namespace Task_24
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumber = new int[30] { 1, 1, 1, 1, 4, 3, 3, 3, 5, 6, 0, 8, 8, 8, 8, 8, 2, 4, 3, 2, 4, 2, 3, 4, 3, 4, 4, 5, 5, 5 };
            int numberIteration = 0;
            int numberInArray = 0;
            int numberIterationTwo = 0;
            int numberInArrayTwo = 0;

            for (int i = 0; i < arrayNumber.Length; i++)
            {
                Console.Write(arrayNumber[i] + " ");
             }

            for (int i = 0; i < arrayNumber.Length; i++)
            {
                if (numberInArrayTwo == arrayNumber[i])
                {
                    numberIterationTwo++;
                }
                else
                {
                    if (numberIterationTwo > numberIteration)
                    {
                        numberIteration = numberIterationTwo;
                        numberInArray = numberInArrayTwo;
                    }
                    else
                    {
                        numberInArrayTwo = arrayNumber[i];
                        numberIterationTwo = 1;
                    }
                }
            }

            Console.WriteLine($"\nЧисло {numberInArray} повторяется {numberIteration} раз.");
        }
    }
}