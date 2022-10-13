using System;

namespace Task_23
{
    class Program
    {
        static void Main(string[] args)
        {
            string exitComand = "exit";
            string sumComand = "sum";
            string userInput;
            Console.WriteLine($"Введите число либо команду:\n{sumComand} для сложения массива.\n{exitComand} для выхода.\nлюбое число для наполнения массива.");
            bool isWork = true;
            int numberArray;
            int[] arrayNumber = new int[0];

            while (isWork)
            {
                userInput = Console.ReadLine();

                if (userInput ==exitComand)
                {
                    isWork = false;
                }
                else if(userInput==sumComand)
                {
                    int resaultSumNumber = 0;

                    for (int i=0;i<arrayNumber.Length;i++)
                    {
                        resaultSumNumber += arrayNumber[i];
                    }

                    Console.WriteLine($"Сумма чисел массива = {resaultSumNumber}.");
                }
                else
                {
                    numberArray = int.Parse(userInput);
                    int[] newArrayNumber = new int[arrayNumber.Length+1];
                    
                    for(int j=0;j<arrayNumber.Length;j++)
                    {
                        newArrayNumber[j] = arrayNumber[j];
                    }

                    newArrayNumber[arrayNumber.Length-1] = numberArray;

                    arrayNumber = newArrayNumber;
                }
            }
        }
    }
}