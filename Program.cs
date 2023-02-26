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
            List<int> dynamicArray = new List<int>();

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
                    SumNumbersInArray(ref dynamicArray);
                }
                else
                {
                    AddNumbersOutConsole(ref dynamicArray, userInput);
                }

                static void SumNumbersInArray(ref List <int> dynamicArray)
                {
                    int sumNumbers = 0;

                    for (int i = 0; i < dynamicArray.Count; i++)
                    {
                        sumNumbers += dynamicArray[i];
                    }

                    Console.WriteLine($"Сумма массива: {sumNumbers}");
                }

                static void AddNumbersOutConsole(ref List<int> dynamicArray, string userInput)
                {
                    int userEnterNumber;
                    bool result = int.TryParse(userInput, out userEnterNumber);

                    if (result)
                    {
                        dynamicArray.Add(userEnterNumber);
                        Console.Write("Ваш массив:");

                        for (int i = 0; i < dynamicArray.Count; i++)
                        {
                            Console.Write(dynamicArray[i] + " ");
                        }

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
            }
        }
    }
}
