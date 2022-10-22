using System;

namespace Task_24
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumber = new int[30];
            int numberIteration = 0;
            int numberInArray = 0;
            int numberIterationTwo = 0;
            int numberInArrayTwo = 0;
            int minValueNumber = 0;
            int maxValueNumber = 30;
            Random random = new Random();
            Console.WriteLine("Ваш массив с рандомными числами: ");

            for (int i = 0; i < arrayNumber.Length; i++)
            {
                arrayNumber[i] = random.Next(minValueNumber, maxValueNumber);
                Console.Write(arrayNumber[i] + " ");
            }

            for (int i = 0; i < arrayNumber.Length; i++)
            {
                if (numberInArrayTwo == arrayNumber[i])
                {
                    numberIterationTwo++;
                }
                else if (numberIterationTwo > numberIteration)
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

            if(numberIteration == 0||numberIteration ==1)
            {
                Console.WriteLine($"\nЧисел повторяющихся несколько раз нет.");
            }
            else
            {
                Console.WriteLine($"\nЧисло {numberInArray} повторяется {numberIteration} раз.");
            }
        }
    }
}