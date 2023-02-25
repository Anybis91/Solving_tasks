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
                Console.WriteLine($"Для работы с массивом введите число. Для расчета массива введите {sumCommand}, для выхода введите {exitCommand}.");
                string userInput = Console.ReadLine();
                int userEnterNumber;
                bool result =int.TryParse(userInput, out userEnterNumber);

                if (userInput == exitCommand)
                {
                    isWork = false;
                    Console.WriteLine("Всего доброго!");
                }
                else if (userInput == sumCommand)
                {
                    int sumNumbers=0;

                    for(int i = 0; i < dynamicArray.Count; i++)
                    {
                        sumNumbers+=dynamicArray[i];
                    }

                    Console.WriteLine($"Сумма массива: {sumNumbers}");

                }
                else if(result)
                {
                    dynamicArray.Add(userEnterNumber);
                    Console.Write("Ваш массив:");

                    for (int i = 0; i < dynamicArray.Count; i++)
                    {
                        Console.Write(dynamicArray[i]+" ");
                    }

                    Console.WriteLine("\n");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Число введено не корректно! Повторите попытку.");
                }
            }
        }
    }
}
