using System;

namespace Task_9_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите exit для выхода.");
            string userInput;
            int amountCycle;
            string exitCommand = "exit";
            bool cycleIsEnd=true;

            while(cycleIsEnd)
            {
                userInput=Console.ReadLine();

                if (userInput==exitCommand)
                {
                    Console.WriteLine("Цикл завершён!");
                    break;
                }
                else
                {
                    Console.WriteLine("Цикл будет запущен снова!");
                }
            }
        }
    }
}
