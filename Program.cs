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
                    AddNumbersInArray(ref arrayNumbers, userInput);
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

        static void AddNumbersInArray(ref List<int> arrayNumbers, string userInput)
        {
            int userEnterNumber;
            bool result = int.TryParse(userInput, out userEnterNumber);

            if (result)
            {
                arrayNumbers.Add(userEnterNumber);
                OutConsoleArray(arrayNumbers);
                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Число введено не корректно! Повторите попытку.");
                Console.ReadKey();
                Console.Clear();
            }
        }
        static void OutConsoleArray(List<int> arrayNumbers)
        {
            Console.Write("Ваш массив:");

            for (int i = 0; i < arrayNumbers.Count; i++)
            {
                Console.Write(arrayNumbers[i] + " ");
            }
        }
    }
}
