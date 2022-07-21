using System;

namespace Task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int usdToRub = 55;
            int btcToRub = 1398822;
            float rubAmount;
            float usdAmount;
            float btcAmount;
            string userInput;
            float userWantConvert;
            bool isWork = true;
            string exitCommand = "exit";

            Console.WriteLine("Доброго дня!Вас приветствует обменник валют!");
            Console.Write("Введите сумму доступных средств в рублях:");
            rubAmount = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите сумму доступных средств в долларах:");
            usdAmount = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите сумму доступных средств в биткоинах:");
            btcAmount = Convert.ToSingle(Console.ReadLine());
            Console.Write("Выбирите необходимую операцию:\n 1 - Обмен рублей на доллары.\n 2 - Обмен долларов на рубли.\n 3 - Обмен биткоинов на рубли.\n Для выхода введите exit.\n");
            userInput = Console.ReadLine();

            while(isWork)
            {
                if (userInput == exitCommand)
                {
                    Console.Write("Всего доброго!");
                }
                else
                {
                    switch (userInput)
                    {
                        case "1":
                            Console.Write("Сколько рублей вы хотите сконвертировать?\n");
                            userWantConvert = Convert.ToSingle(Console.ReadLine());

                            if (userWantConvert <= rubAmount)
                            {
                                rubAmount -= userWantConvert;
                                usdAmount += userWantConvert / usdToRub;

                            }
                            else
                            {
                                Console.Write("Не достаточно средств!");
                            }
                            break;
                        case "2":
                            Console.Write("Сколько долларов вы хотите сконвертировать?\n");
                            userWantConvert = Convert.ToSingle(Console.ReadLine());

                            if (userWantConvert <= usdAmount)
                            {
                                usdAmount -= userWantConvert;
                                rubAmount += userWantConvert * usdToRub;

                            }
                            else
                            {
                                Console.Write("Не достаточно средств!");
                            }
                            break;
                        case "3":
                            Console.Write("Сколько биткоинов вы хотите сконвертировать?\n");
                            userWantConvert = Convert.ToSingle(Console.ReadLine());

                            if (userWantConvert <= btcAmount)
                            {
                                btcAmount -= userWantConvert;
                                rubAmount += userWantConvert * btcToRub;

                            }
                            else
                            {
                                Console.Write("Не достаточно средств!\n");
                            }
                            break;
                    }

                    Console.Write($"Ваш баланс равен:\n{rubAmount} - рублей.\n{usdAmount} - долларов.\n{btcAmount} - биткоинов.\n");
                }
                
            }
        }
    }
}
