using System;

namespace Task_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberAttempts=3;
            string basePassword="873456";
            string userInputPassword;
            string baseinfo = "Секретная информация:\nБулочки были выпечены в подвале в Москве.";

            for (int i=0; i<numberAttempts; i++)
            {
                Console.WriteLine("Введите пароль для доступа к данным:");
                userInputPassword = Console.ReadLine();

                if (userInputPassword == basePassword)
                {
                    Console.WriteLine(baseinfo);
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный пароль! Осталось " + (numberAttempts-i-1) + " попыток!");
                }
            }
        }
    }
}
