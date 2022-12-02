using System;
using System.ComponentModel;

namespace Task_
{
    class Program
    {
        //Будет 2 массива: 1) фио 2) должность.
        //Описать функцию заполнения массивов досье, функцию форматированного вывода, функцию поиска по фамилии и !!!функцию удаления досье.
        // Функция расширяет уже имеющийся массив на 1 и дописывает туда новое значение.
        // Программа должна быть с меню, которое содержит пункты:
        //1) добавить досье
        //2) вывести все досье(в одну строку через “-” фио и должность с порядковым номером в начале)
        //3) удалить досье(Массивы уменьшаются на один элемент.Нужны дополнительные проверки, чтобы не возникало ошибок)
        //4) поиск по фамилии
        //5) выход
        static void Main(string[] args)
        {
            string[] surname = new string[5];
            string[] position = new string[5];
            bool isWork = true;
            int userSelection;
            string searchSurname;

            while (isWork)
            {
                Console.WriteLine("Выберите пункт меню:\n1. Добавить досье.\n2. Вывести все досье.\n3. Удалить досье.\n4. Поиск по фамилии.\n5. Выход.");
                Console.WriteLine("Введите номер команды:");
                userSelection = Convert.ToInt32(Console.ReadLine());

                switch (userSelection)
                {
                    case 1:
                        string personality;
                        string personalityPosition;
                        int numberEmployees;
                        Console.WriteLine("Введите порядковый номер сотрудника:");
                        numberEmployees = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.WriteLine("Введите ФИО сотрудника:");
                        personality = Console.ReadLine();
                        Console.WriteLine("Введите должность сотрудника:");
                        personalityPosition = Console.ReadLine();
                        surname[numberEmployees] += personality;
                        position[numberEmployees] += personalityPosition;
                        break;
                    case 2:
                        for (int i = 0; i < surname.Length; i++)
                        {
                            Console.WriteLine((i + 1) + "." + surname[i] + " - " + position[i]);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Введите номер, досье которго необходимо удалить:");
                        int deleteIndex = int.Parse(Console.ReadLine())-1;
                        DeleteArrayElement<string>(ref surname, deleteIndex);
                        break;
                    case 4:
                        bool surnameIsFind = false;
                        Console.WriteLine("Введите ФИО сотрудника:");
                        searchSurname = Console.ReadLine();

                        for (int i = 0; i < surname.Length; i++)
                        {
                            if (searchSurname.ToLower() == surname[i].ToLower())
                            {
                                Console.WriteLine((i + 1) + "." + surname[i] + " - " + position[i]);
                                surnameIsFind = true;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Тaкого сотрудника нет!");
                                break;
                            }
                        }
                        break;
                    case 5:
                        isWork = false;
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
        static void DeleteArrayElement<T>(ref T[] surname, int i)
        {
            if (i == surname.GetUpperBound(0))
            {
                Array.Resize<T>(ref surname, surname.Length - 1);
            }
            else
            {
                surname[i] = surname[i + 1];
                DeleteArrayElement<T>(ref surname, i + 1);
            }
        }
        
        static string SearchSurname()
        {

            string[] surname = new string[5];
            string[] position = new string[5];
            string searchSurname;
            bool surnameIsFind = false;

            for (int i = 0; i < surname.Length; i++)
            {
                if (searchSurname.ToLower() == surname[i].ToLower())
                {
                    Console.WriteLine((i + 1) + "." + surname[i] + " - " + position[i]);
                    surnameIsFind = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Тaкого сотрудника нет!");
                    break;
                }
            }
        }
    }
}