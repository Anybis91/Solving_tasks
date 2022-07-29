using System;

namespace Task_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberAttempts=3;
            int useNumberAttempts = 1;
            string basePassword="873456";
            string userInputPassword;
            string baseinfo = "Секретная информация:\nБулочки были выпечены в подвале в Москве.";
            bool isWork = true;

            while (isWork)
            {
                Console.WriteLine("Введите пароль для доступа к данным:");
                userInputPassword = Console.ReadLine();

                if (userInputPassword == basePassword)
                {
                    Console.WriteLine(baseinfo);
                    isWork = false;
                }
                else
                {
                    if (numberAttempts <= 0)
                    {
                        Console.WriteLine("У вас не осталось попыток!\nВсего доброго!");
                        isWork = false;
                    }
                    else
                    {
                        Console.WriteLine("Неверный пароль! Осталось " + (numberAttempts) + " попыток!");
                        numberAttempts = numberAttempts - useNumberAttempts;
                    }
                }
            }
        }
    }
}
