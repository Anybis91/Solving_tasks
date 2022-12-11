using System;
using System.Reflection.Metadata;

namespace Task_Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] surnameNamePatronymic = new string[1];
            string[] position = new string[1];
            string personality;
            int idPersonality;
            string personalityPosition;
            int numberEmployees;
            int userSelection;
            bool isWork=true;

            while (isWork)
            {
                Console.WriteLine("Выберите пункт меню:\n1. Добавить досье.\n2. Вывести все досье.\n3. Выход.");
                Console.WriteLine("Введите номер команды:");
                userSelection = Convert.ToInt32(Console.ReadLine());

                switch (userSelection)
                {
                    case 1:
                        Console.WriteLine("Введите номер сотрудника по порядку:");
                        idPersonality = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите ФИО сотрудника:");
                        personality = Console.ReadLine();
                        Console.WriteLine("Введите должность сотрудника:");
                        personalityPosition = Console.ReadLine();
                        ExpendArray(surnameNamePatronymic);
                        ExpendArray(position);
                        surnameNamePatronymic[idPersonality-1] += personality;
                        position[idPersonality-1] += personalityPosition;
                        break;
                    case 2:
                        for (int i = 0; i < surnameNamePatronymic.Length; i++)
                        {
                            Console.WriteLine((i + 1) + "." + surnameNamePatronymic[i] + " - " + position[i]);
                        }
                        break;
                    case 3:
                        isWork = false;
                        break;
                }


                Console.ReadKey();
                Console.Clear();
            }
        }

        static void ExpendArray(string[]a)
        {
            string[] tempArray = new string[a.Length + 1];

            for (int i = 0; i < a.Length; i++)
            {
                tempArray[i] = a[i];
            }

            a = tempArray;
        }
    }
}
