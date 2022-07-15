using System;

namespace Task_9_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int amountCycle;
            string exitCommand = "exit";
            bool isWork = true;
            Console.WriteLine($"Введите {exitCommand} для выхода.");

            while(isWork)
            {
                userInput=Console.ReadLine();

                if (userInput==exitCommand)
                {
                    Console.WriteLine("Цикл завершён!");
                    isWork=false;
                }
                else
                {
                    Console.WriteLine("Цикл будет запущен снова!");
                }
            }
        }
    }
}
