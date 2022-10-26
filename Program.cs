using System;

namespace Task_24
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[30];
            int numberIteration = 1;
            int numberInArray = 0;
            int saveNumber=0;
            int saveIteration = 0;
            int minValueNumber = 0;
            int maxValueNumber = 10;
            Random random = new Random();
            Console.WriteLine("Ваш массив с рандомными числами: ");

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(minValueNumber, maxValueNumber);
                Console.Write(myArray[i] + " ");
            }

            for (int i = 0; i < myArray.Length-1; i++)
            {
                if (myArray[i] == myArray[i+1])
                {
                    numberIteration++;
                    numberInArray=myArray[i];
                }
                else if (myArray[i+1] != myArray[i])
                {
                    if (saveIteration < numberIteration|| saveIteration == numberIteration)
                    {
                        saveNumber = numberInArray;
                        saveIteration = numberIteration;
                    }
                    else if(saveIteration>numberIteration)
                    {
                        numberIteration = 1;
                        numberInArray = myArray[i];
                    }
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