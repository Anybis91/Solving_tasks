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
            bool isWorkFirstSection = true;
            bool isWorkSecondSection = true;
            bool isWorkThirdSection = true;
            bool isWorkMainSection = true;
            string exitCommand = "выход";
            string backCommand = "назад";

            while (isWorkMainSection)
            {
                Console.Write("Выбирите необходимую операцию:\nКонвертер - Обмен различных валют.\nДанные - доступ к библиотеке.\nНастройка - настройка консоли.\nДля выхода введите 'выход'.\n");
                userInput = Console.ReadLine();

                if (userInput == exitCommand)
                {
                    Console.Write("Всего доброго!");
                    isWorkMainSection = false;
                }
                else
                {
                    switch (userInput)
                    {
                        case "Конвертер":
                            Console.WriteLine("Доброго дня! Вас приветствует обменник валют!");
                            Console.Write("Введите сумму доступных средств в рублях:");
                            rubAmount = Convert.ToSingle(Console.ReadLine());
                            Console.Write("Введите сумму доступных средств в долларах:");
                            usdAmount = Convert.ToSingle(Console.ReadLine());
                            Console.Write("Введите сумму доступных средств в юанях:");
                            cnyAmount = Convert.ToSingle(Console.ReadLine());

                            while (isWorkFirstSection)
                            {
                                Console.Write("Выбирите необходимую операцию:\n 1 - Обмен рублей на доллары.\n 2 - Обмен долларов на рубли." +
                                    "\n 3 - Обмен юаней на рубли.\n 4 - Обмен долларов на юани.\n 5 - Обмен рублей на юани." +
                                    "\n 6 - Обмен юаней на доллары.\n Для выхода в главный раздел введите 'назад'.\n");
                                userInput = Console.ReadLine();

                                if (userInput == backCommand)
                                {
                                    Console.Write("Всего доброго!\n");
                                    isWorkFirstSection = false;
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
                            break;
                        case "Данные":
                            string userName;
                            string userPassword;
                            string userInfo;
                            int numberAttempts = 5;
                            int numberCycles;
                            string userInputName;
                            string userInputPassword;

                            while (isWorkSecondSection)
                            {
                                Console.WriteLine("Доброго дня!\nЭто база данных пользователя, в этом разделе вы можите ввести логин, пароль и данные.\nДля выхода в главный раздел введите 'назад'.\nДля продолженния нажмите лювую клавишу:\n");
                                userInput = Console.ReadLine();

                                if (userInput == backCommand)
                                {
                                    Console.Write("Всего доброго!");
                                    isWorkSecondSection = false;
                                }
                                else
                                {
                                    string answerYes = "y";
                                    string answerNo = "n";
                                    Console.WriteLine("Введите имя пользователя:");
                                    userName = Console.ReadLine();
                                    Console.WriteLine("Придумайте пароль:");
                                    userPassword = Console.ReadLine();
                                    Console.WriteLine("Введите данные:");
                                    userInfo = Console.ReadLine();
                                    Console.WriteLine($"Хотите получить доступ к данным? {answerYes} - да, {answerNo} - нет.");
                                    userInput = Console.ReadLine();

                                    if (userInput == answerYes)
                                    {
                                        for (numberCycles = 0; numberCycles <= numberAttempts; numberCycles++)
                                        {
                                            Console.WriteLine("Введите имя пользователя:");
                                            userInputName = Console.ReadLine();
                                            Console.WriteLine("Введите пароль:");
                                            userInputPassword = Console.ReadLine();

                                            if (userInputPassword == userPassword && userInputName == userName)
                                            {
                                                Console.WriteLine("Ваши данные:\n" + userInfo + "\n");
                                            }
                                            else
                                            {
                                                Console.WriteLine($"Неверное имя пользователя или пароль!\n Осталось {numberAttempts - 1} попыток!");
                                                numberAttempts--;
                                            }
                                            break;
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Все данные удалены!\nВсего доброго!");
                                        break;
                                    }
                                }
                            }
                            break;
                        case "Настройка":
                            Console.WriteLine("Доброго дня! Вас приветствует настройка консоли!");

                            while (isWorkThirdSection)
                            {
                                Console.Write("1 - Смена цвета текста в консоли.\n2 - Смена фона консоли." +
                                    "\nДля выхода в главный раздел введите 'назад'.\n");
                                userInput = Console.ReadLine();

                                if (userInput == backCommand)
                                {
                                    Console.Write("Всего доброго!\n");
                                    isWorkThirdSection = false;
                                }
                                else
                                {
                                    switch (userInput)
                                    {

                                        case "1":
                                            Console.Write("Для смены цвета текста выбирете пункт:\nК - красный.\nС - синий.\nЗ - зеленый.\nБ - Белый(по умолчанию).\n");
                                            userInput = Console.ReadLine();

                                            switch (userInput)
                                            {
                                                case "К":
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    break;
                                                case "С":
                                                    Console.ForegroundColor = ConsoleColor.Blue;
                                                    break;
                                                case "З":
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    break;
                                                case "Б":
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    break;
                                            }
                                            break;
                                        case "2":
                                            Console.Write("Для смены цвета консоли выбирете пункт:\nК - красный.\nС - синий.\nЗ - зеленый.\nЧ - черный(по умолчания).\n");
                                            userInput = Console.ReadLine();

                                            switch (userInput)
                                            {
                                                case "К":
                                                    Console.BackgroundColor = ConsoleColor.Red;
                                                    break;
                                                case "С":
                                                    Console.BackgroundColor = ConsoleColor.Blue;
                                                    break;
                                                case "З":
                                                    Console.BackgroundColor = ConsoleColor.Green;
                                                    break;
                                                case "Ч":
                                                    Console.BackgroundColor = ConsoleColor.Black;
                                                    break;
                                            }
                                            break;

                                    }
                                }
                            }
                            break;
                    }
                }
            }
        }
    }
}