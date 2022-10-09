using System;

namespace Task_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длинну массива: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int[] arrayNumber = new int[userInput];

            if (userInput > 3)
            {
                int minValueNumber = 0;
                int maxValueNumber = 30;
                Random random = new Random();
                Console.WriteLine("Ваш массив с рандомными числами: ");

                for (int i = 0; i < arrayNumber.Length; i++)
                {
                    arrayNumber[i] = random.Next(minValueNumber, maxValueNumber);
                    Console.Write(arrayNumber[i] + " ");
                }

                if (arrayNumber[0] > arrayNumber[1])
                {
                    Console.WriteLine("\nПервый локальный максимум: " + arrayNumber[0]);
                }

                for (int i = 1; i < arrayNumber.Length - 1; i++)
                {
                    if (arrayNumber[i] > arrayNumber[i - 1] && arrayNumber[i] > arrayNumber[i + 1])
                    {
                        Console.WriteLine("\nЛокальный максимум: " + arrayNumber[i]);
                    }
                }

                if (arrayNumber[arrayNumber.Length - 1] > arrayNumber[arrayNumber.Length - 2])
                {
                    Console.WriteLine("\nПоследний локальный максимум: " + arrayNumber[arrayNumber.Length - 1]);
                }
            }
            else
            {
                Console.WriteLine("\nМассив слишком маленький!");
            }
        }
    }
}