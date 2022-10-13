using System;

namespace Task_23
{
    class Program
    {
        //Пользователь вводит числа, и программа их запоминает.
        //Как только пользователь введёт команду sum, программа выведет сумму всех веденных чисел.
        //Выход из программы должен происходить только в том случае, если пользователь введет команду exit.
        //Если введено не sum и не exit, значит это число и его надо добавить в массив.
        //Программа должна работать на основе расширения массива.
        // Внимание, нельзя использовать List<T> и Array.Resize
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
                    int[] newArrayNumber= new int[arrayNumber.Length+1];
                    newArrayNumber[arrayNumber.Length-1] = numberArray;

                    for (int i=0;i< newArrayNumber.Length;i++)
                    {
                        Console.WriteLine(newArrayNumber[i] + " ");
                    }
                }
            }
        }
    }
}