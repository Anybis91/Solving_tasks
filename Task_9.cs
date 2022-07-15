using System;

namespace Task_9_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите exit для выхода.");
            String userinput;
            int amountCycle;

            for(amountCycle = 1; amountCycle > 0; amountCycle++)
                {
                userinput=Console.ReadLine();

                if (userinput == "exit")
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
