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
                        Console.WriteLine("Введите ФИО сотрудника:");
                        personality = Console.ReadLine();
                        Console.WriteLine("Введите должность сотрудника:");
                        personalityPosition = Console.ReadLine();

                        for(int i=0;i<surnameNamePatronymic.Length;i++)
                        {
                            if(surnameNamePatronymic[i]!=null)
                            {
                                string[] tempArray=new string[surnameNamePatronymic[i].Length+1];

                                for(int j=0;j<surnameNamePatronymic.Length;j++)
                                {
                                    tempArray[j] = surnameNamePatronymic[j];
                                }

                                surnameNamePatronymic=tempArray;
                                string[] tempArrayTwo=new string[position[i].Length+1];

                                for(int j=0;j<position.Length;j++)
                                {
                                    tempArrayTwo[j] = position[j];
                                }

                                position = tempArrayTwo;
                                surnameNamePatronymic[i + 1] += personality;
                                position[i+1]+=personalityPosition;
                            }
                            else
                            {
                                surnameNamePatronymic[i] += personality;
                                position[i] += personalityPosition;
                            }
                        }

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
    }
}
