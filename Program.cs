using System;
using System.ComponentModel;
using System.Xml.Linq;

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
            string userSelection;
            string personality;
            string personalityPosition;
            const string AddDossier = "Add a dossier";
            const string OutputDossiers = "Output all dossiers";
            const string DeleteDossier = "Delete the dossier";
            const string SearchLastName = "Search by last name";
            const string CommandExit = "exit";


            while (isWork)
            {
                Console.WriteLine($"Выберите пункт меню:\n{AddDossier}. - Добавить досье.\n{OutputDossiers}. -  Вывести все досье.\n{DeleteDossier}. - Удалить досье.\n{SearchLastName}. - Поиск по фамилии.\n{CommandExit}. - Выход.");
                Console.WriteLine("Введите команду:");
                userSelection = Console.ReadLine();

                switch (userSelection)
                {
                    case AddDossier:
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
                    case OutputDossiers:
                        for (int i = 0; i < surnameNamePatronymic.Length; i++)
                        {
                            Console.WriteLine((i + 1) + "." + surnameNamePatronymic[i] + " - " + position[i]);
                        }
                        break;
                    case DeleteDossier:
                        Console.WriteLine("Введите номер, досье которго необходимо удалить:");
                        int deleteIndex = int.Parse(Console.ReadLine())-1;
                        DeleteArrayElement<string>(ref surnameNamePatronymic, deleteIndex);
                        DeleteArrayElement<string>(ref position, deleteIndex);
                        break;
                    case SearchLastName:
                        SeachInArray(surnameNamePatronymic, position);
                        break;
                    case CommandExit:
                        isWork = false;
                        break;
                    default:
                        Console.WriteLine("Некоректный ввод.");
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

        static void SeachInArray(string[] surnameNamePatronymic, string[] position)
        {
            Console.WriteLine("Введите ФИО сотрудника:");
            string searchSurname = Console.ReadLine();

            for (int i = 0; i < surnameNamePatronymic.Length; i++)
            {
                string[] tempSurnameArray = surnameNamePatronymic[i].Split(' ');

                for (int j = 0; j < tempSurnameArray.Length; j++)
                {
                    if (tempSurnameArray[j] == searchSurname)
                    {
                        Console.WriteLine((i + 1)+"." + surnameNamePatronymic[i] + " - " + position[i]);
                    }
                }

            }
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