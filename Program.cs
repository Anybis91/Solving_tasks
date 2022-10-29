using System;

namespace Task_24
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = new int[30];
            int numberIteration = 1;
            int numberInArray = 0;
            int saveNumber=0;
            int saveIteration = 0;
            int minValueNumber = 0;
            int maxValueNumber = 10;
            Random random = new Random();
            Console.WriteLine("Ваш массив с рандомными числами: ");

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                arrayNumbers[i] = random.Next(minValueNumber, maxValueNumber);
                Console.Write(arrayNumbers[i] + " ");
            }

            for (int i = 0; i < arrayNumbers.Length-1; i++)
            {
                if (arrayNumbers[i] == arrayNumbers[i+1])
                {
                    numberIteration++;
                    numberInArray= arrayNumbers[i];
                }
                else
                {
                    if (saveIteration < numberIteration|| saveIteration == numberIteration)
                    {
                        saveNumber = numberInArray;
                        saveIteration = numberIteration;
                    }
                    
                    numberIteration = 1;
                    numberInArray = arrayNumbers[i];
                }
            }

            if (saveIteration == 1)
            {
                Console.WriteLine($"\nВсе числа повторяются максимальное число раз.");
            }
            else
            {
                Console.WriteLine($"\nЧисло {saveNumber} повторяется {saveIteration} раз.");
            }
        }
    }
}