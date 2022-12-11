using System;
using System.ComponentModel;

namespace Task_28
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string[] surnameNamePatronymic = new string[1];
            string[] position = new string[1];
            bool isWork = true;
            int idPersonality;
            int userSelection;
            string searchSurname;
            string personality;
            string personalityPosition;

            while (isWork)
            {
                Console.WriteLine("Выберите пункт меню:\n1. Добавить досье.\n2. Вывести все досье.\n3. Удалить досье.\n4. Поиск по фамилии.\n5. Выход.");
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
                        ExpendArray(ref surnameNamePatronymic);
                        ExpendArray(ref position);
                        surnameNamePatronymic[idPersonality - 1] += personality;
                        position[idPersonality - 1] += personalityPosition;
                        break;
                    case 2:
                        for (int i = 0; i < surnameNamePatronymic.Length; i++)
                        {
                            Console.WriteLine((i + 1) + "." + surnameNamePatronymic[i] + " - " + position[i]);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Введите номер, досье которго необходимо удалить:");
                        int deleteIndex = int.Parse(Console.ReadLine())-1;
                        DeleteArrayElement<string>(ref surnameNamePatronymic, deleteIndex);
                        DeleteArrayElement<string>(ref position, deleteIndex);
                        break;
                    case 4:
                        bool surnameIsFind = false;
                        Console.WriteLine("Введите ФИО сотрудника:");
                        searchSurname = Console.ReadLine();
                        SeachInArray(surnameNamePatronymic, position, searchSurname);
                        break;
                    case 5:
                        isWork = false;
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }

        static void DeleteArrayElement<T>(ref T[] a, int i)
        {
            if (i == a.GetUpperBound(0))
            {
                Array.Resize<T>(ref a, a.Length - 1);
            }
            else
            {
                a[i] = a[i + 1];
                DeleteArrayElement<T>(ref a, i + 1);
            }
        } 

        static void SeachInArray(string[] a, string[] b, string c)
        {
            for (int i = 0; i < a.Length; i++)
            {
                string tempSurname = a[i];
                string[] stempSurnameArray = tempSurname.Split(' ');

                foreach (var sub in stempSurnameArray)
                {
                    if (sub.ToLower() == c.ToLower())
                    {
                        Console.WriteLine((i + 1) + "." + a[i] + " - " + b[i]);
                    }
                }
            }
            Console.ReadKey();
        }

        static void ExpendArray(ref string[] a)
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