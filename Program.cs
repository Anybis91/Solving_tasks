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
            string userSelection;
            const string AddDossier = "1";
            const string OutputDossiers = "2";
            const string DeleteDossier = "3";
            const string SearchLastName = "4";
            const string CommandExit = "exit";


            while (isWork)
            {
                Console.WriteLine($"Выберите пункт меню:\n{AddDossier}. Добавить досье.\n{OutputDossiers}. Вывести все досье.\n{DeleteDossier}. Удалить досье.\n{SearchLastName}. Поиск по фамилии.\n{CommandExit}. - Выход.");
                Console.WriteLine("Введите команду:");
                userSelection = Console.ReadLine();

                switch (userSelection)
                {
                    case AddDossier:
                        AddDossiersInArray(ref surnameNamePatronymic, ref position);
                        break;
                    case OutputDossiers:
                        InputDisplayDossiers(ref surnameNamePatronymic, ref position);
                        break;
                    case DeleteDossier:
                        DeleteDossierFull(ref surnameNamePatronymic, ref position);
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

        static void DeleteDossierFull (ref string[] surnameNamePatronymic,ref string[] position)
        {
            Console.WriteLine("Введите номер, досье которго необходимо удалить:");
            int deleteIndex = int.Parse(Console.ReadLine()) - 1;
            DeleteArrayElement<string>(ref surnameNamePatronymic, deleteIndex);
            DeleteArrayElement<string>(ref position, deleteIndex);
        }
        static void DeleteArrayElement<T>(ref T[] surnameNamePatronymic, int deleteIndex)
        {
            if (deleteIndex == surnameNamePatronymic.GetUpperBound(0))
            {
                Array.Resize<T>(ref surnameNamePatronymic, surnameNamePatronymic.Length - 1);
            }
            else
            {
                surnameNamePatronymic[deleteIndex] = surnameNamePatronymic[deleteIndex + 1];
                DeleteArrayElement<T>(ref surnameNamePatronymic, deleteIndex + 1);
            }
        } 

        static void SeachInArray(string[] surnameNamePatronymic, string[] position)
        {
            Console.WriteLine("Введите ФИО сотрудника:");
            string searchSurname = Console.ReadLine();

            for (int i = 0; i < surnameNamePatronymic.Length; i++)
            {
                string[] tempSurnameArray = surnameNamePatronymic[i].Split(' ');

                if (tempSurnameArray[i] == searchSurname)
                {
                    Console.WriteLine((i + 1) + "." + surnameNamePatronymic[i] + " - " + position[i]);
                }
            }
        }

        static void ExpendArray(ref string[] surnameNamePatronymic)
        {
            string[] tempArray = new string[surnameNamePatronymic.Length + 1];

            for (int i = 0; i < surnameNamePatronymic.Length; i++)
            {
                tempArray[i] = surnameNamePatronymic[i];
            }

            surnameNamePatronymic = tempArray;
        }

        static void InputDisplayDossiers (ref string[] surnameNamePatronymic, ref string[] position)
        {
            for (int i = 0; i < surnameNamePatronymic.Length; i++)
            {
                Console.WriteLine((i + 1) + "." + surnameNamePatronymic[i] + " - " + position[i]);
            }
        }

        static void AddDossiersInArray (ref string[] surnameNamePatronymic, ref string[] position)
        {
            Console.WriteLine("Введите номер сотрудника по порядку:");
            int idPersonality = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ФИО сотрудника:");
            string personality = Console.ReadLine();
            Console.WriteLine("Введите должность сотрудника:");
            string personalityPosition = Console.ReadLine();
            ExpendArray(ref surnameNamePatronymic);
            ExpendArray(ref position);
            surnameNamePatronymic[idPersonality - 1] += personality;
            position[idPersonality - 1] += personalityPosition;
        }
    }
}