using System;

namespace Task_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNumberRandom=1;
            int maxNumberRandom=28;
            int minValueNumber = 100;
            int maxValueNumber = 1000;
            Random random = new Random();
            int quantityNumber = 0;
            int summNumberN=0;
            int randomNumberN = random.Next(minNumberRandom, maxNumberRandom);
            bool isWork = true; Console.WriteLine($"Случайное число {randomNumberN}.");

            while (isWork)
            {
                summNumberN += randomNumberN;

                if(summNumberN > minValueNumber&&summNumberN<maxValueNumber)
                {
                    quantityNumber++;
                }
                else if(summNumberN > maxValueNumber)
                {
                    Console.WriteLine($"Количество трехзначных натуральных чисел от числа {randomNumberN} равно {quantityNumber}.");
                    isWork = false;
                }
            }
            
        }
    }
}