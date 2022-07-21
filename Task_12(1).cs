using System;

namespace Task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            float usdToRub = 55;
            float rubToUsd = 0.0178571f;
            float cnyToRub = 8.16f;
            float cnyToUsd = 0.14877f;
            float usdToCny = 6.72f;
            float rubToCny = 0.12255f;
            float rubAmount;
            float usdAmount;
            float cnyAmount;
            string userInput;
            float userWantConvert;
            bool isWork = true;
            string exitCommand = "exit";

            Console.WriteLine("Доброго дня!Вас приветствует обменник валют!");
            Console.Write("Введите сумму доступных средств в рублях:");
            rubAmount = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите сумму доступных средств в долларах:");
            usdAmount = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите сумму доступных средств в юанях:");
            cnyAmount = Convert.ToSingle(Console.ReadLine());

            while(isWork)
            {
                Console.Write("Выбирите необходимую операцию:\n 1 - Обмен рублей на доллары.\n 2 - Обмен долларов на рубли." +
                    "\n 3 - Обмен юаней на рубли.\n 4 - Обмен долларов на юани.\n 5 - Обмен рублей на юани." +
                    "\n 6 - Обмен юаней на доллары.\n Для выхода введите exit.\n");
                userInput = Console.ReadLine();

                if (userInput == exitCommand)
                {
                    Console.Write("Всего доброго!");
                    break;
                }
                else
                {
                    switch (userInput)
                    {
                        case "1":
                            Console.Write("Сколько рублей вы хотите сконвертировать в доллары?\n");
                            userWantConvert = Convert.ToSingle(Console.ReadLine());

                            if (userWantConvert <= rubAmount)
                            {
                                rubAmount -= userWantConvert;
                                usdAmount += userWantConvert * rubToUsd;

                            }
                            else
                            {
                                Console.Write("Не достаточно средств!\n");
                            }
                            break;
                        case "2":
                            Console.Write("Сколько долларов вы хотите сконвертировать в рубли?\n");
                            userWantConvert = Convert.ToSingle(Console.ReadLine());

                            if (userWantConvert <= usdAmount)
                            {
                                usdAmount -= userWantConvert;
                                rubAmount += userWantConvert * usdToRub;

                            }
                            else
                            {
                                Console.Write("Не достаточно средств!\n");
                            }
                            break;
                        case "3":
                            Console.Write("Сколько юаней вы хотите сконвертировать в рубли?\n");
                            userWantConvert = Convert.ToSingle(Console.ReadLine());

                            if (userWantConvert <= cnyAmount)
                            {
                                cnyAmount -= userWantConvert;
                                rubAmount += userWantConvert * cnyToRub;

                            }
                            else
                            {
                                Console.Write("Не достаточно средств!\n");
                            }
                            break;
                        case "4":
                            Console.Write("Сколько долларов вы хотите сконвертировать в юани?\n");
                            userWantConvert = Convert.ToSingle(Console.ReadLine());

                            if (userWantConvert <= usdAmount)
                            {
                                usdAmount -= userWantConvert;
                                cnyAmount += userWantConvert * usdToCny;

                            }
                            else
                            {
                                Console.Write("Не достаточно средств!\n");
                            }
                            break;
                        case "5":
                            Console.Write("Сколько рублей вы хотите сконвертировать в юани?\n");
                            userWantConvert = Convert.ToSingle(Console.ReadLine());

                            if (userWantConvert <= rubAmount)
                            {
                                rubAmount -= userWantConvert;
                                cnyAmount += userWantConvert * rubToCny;

                            }
                            else
                            {
                                Console.Write("Не достаточно средств!\n");
                            }
                            break;
                        case "6":
                            Console.Write("Сколько юаней вы хотите сконвертировать в доллары?\n");
                            userWantConvert = Convert.ToSingle(Console.ReadLine());

                            if (userWantConvert <= cnyAmount)
                            {
                                cnyAmount -= userWantConvert;
                                usdAmount += userWantConvert * cnyToUsd;

                            }
                            else
                            {
                                Console.Write("Не достаточно средств!\n");
                            }
                            break;
                    }

                    Console.Write($"Ваш баланс равен:\n{rubAmount} - рублей.\n{usdAmount} - долларов.\n{cnyAmount} - юаней.\n");
                }
            }
        }
    }
}
