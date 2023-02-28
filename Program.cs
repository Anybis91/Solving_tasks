using System;

namespace Task_dynamic_array_advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isWork = true;
            string exitCommand = "exit";
            string sumCommand = "sum";
            List<int> arrayNumbers = new List<int>();

            while (isWork)
            {
                Console.WriteLine($"Для работы с массивом введите число, после ввода нажмите любую клавишу.\nДля расчета массива введите {sumCommand}, для выхода введите {exitCommand}.");
                string userInput = Console.ReadLine();

                if (userInput == exitCommand)
                {
                    isWork = false;
                    Console.WriteLine("Всего доброго!");
                }
                else if (userInput == sumCommand)
                {
                    SumNumbersInArray(arrayNumbers);
                }
                else
                {
                    TryAdd(arrayNumbers, userInput);
                }
            }
        }

        static void SumNumbersInArray(List<int> arrayNumbers)
        {
            int sumNumbers = 0;

            for (int i = 0; i < arrayNumbers.Count; i++)
            {
                sumNumbers += arrayNumbers[i];
            }

            Console.WriteLine($"Сумма массива: {sumNumbers}");
        }

        static void TryAdd(List<int> arrayNumbers, string userInput)
        {
            int number;
            bool isNumber= int.TryParse(userInput, out number);

            if (isNumber)
            {
                arrayNumbers.Add(number);
                OutArray(arrayNumbers);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Число введено не корректно! Повторите попытку.");
            }

            Console.ReadKey();
            Console.Clear();
        }

        static void OutArray(List<int> arrayNumbers)
        {
            Console.Write("Ваш массив:");

            for (int i = 0; i < arrayNumbers.Count; i++)
            {
                Console.Write(arrayNumbers[i] + " ");
            }
        }
    }
}
