using System;
using System.ComponentModel;
using System.Xml.Linq;

namespace Task_28
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string[] fullNames = new string[0];
            string[] positions = new string[0];
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
                Console.Write("\nВведите команду:");
                userSelection = Console.ReadLine();

                switch (userSelection)
                {
                    case AddDossier:
                        AddDossiersInArray(ref fullNames, ref positions);
                        break;
                    case OutputDossiers:
                        InputDisplayDossiers(ref fullNames, ref positions);
                        break;
                    case DeleteDossier:
                        DeleteDossierInArray(ref fullNames, ref positions);
                        break;
                    case SearchLastName:
                        SeachInArray(ref fullNames, ref positions);
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

        static void AddDossiersInArray(ref string[] fullNames, ref string[] positions)
        {
            Console.Write("Введите ФИО сотрудника:");
            string personality = Console.ReadLine();
            ExpendArray(ref fullNames, personality);
            Console.Write("Введите должность сотрудника:");
            string personalityPosition = Console.ReadLine();
            ExpendArray(ref positions, personalityPosition);
        }

        static void ExpendArray(ref string[] fullNames,string personality)
        {
            string[] tempArray = new string[fullNames.Length + 1];

            for (int i = 0; i < fullNames.Length; i++)
            {
                tempArray[i] = fullNames[i];
            }

            tempArray[tempArray.Length-1]=personality;
            fullNames = tempArray;
        }

        static void InputDisplayDossiers(ref string[] fullNames, ref string[] positions)
        {
            for (int i = 0; i < fullNames.Length; i++)
            {
                Console.WriteLine((i + 1) + "." + fullNames[i] + " - " + positions[i]);
            }
        }

        static void DeleteDossierInArray (ref string[] fullNames, ref string[] positions)
        {
            Console.WriteLine("Введите номер, досье которго необходимо удалить:");
            int searchSurname = int.Parse(Console.ReadLine()) - 1;
            DeleteElement(ref fullNames, searchSurname);
            DeleteElement(ref positions, searchSurname);
        } 

        static void DeleteElement (ref string[] fullNames, int searchSurname)
        {
            string[] tempArray = new string[fullNames.Length - 1];
            if (searchSurname > fullNames.Length - 1)
            {
                Console.WriteLine("Такой позиции нет!");
            }
            else
            {
                for (int i = 0, j = 0; i < fullNames.Length; i++)
                {
                    if (i != searchSurname)
                    {
                        tempArray[j] = fullNames[i];
                        j++;
                    }
                }

                fullNames = tempArray;
            }
        }

        static void SeachInArray(ref string[] fullNames, ref string[] positions)
        {
            Console.WriteLine("Введите фамилию сотрудника:");
            string searchSurname = Console.ReadLine();

            for (int i = 0; i < fullNames.Length; i++)
            {
                string[] tempSurnameArray = fullNames[i].Split(' ');

                if (tempSurnameArray[i].ToLower()== searchSurname.ToLower())
                {
                    Console.WriteLine((i + 1) + "." + fullNames[i] + " - " + positions[i]);
                }
            }
        }
    }
}