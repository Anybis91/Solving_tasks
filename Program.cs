using System;
using System.Globalization;

namespace Task_29
{
    class Program
    {
        static void Main(string[] args)
        {
            double healthRemaning;
            int lineSpacing = 3;
            double lengthBar = 100;
            bool isWorkInput = true;

            while(isWorkInput)
            {
                Console.Write("Введите максимальное количество здоровья:");
                double maxHealthUserInput = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите количество оставшегося здоровья:");
                double healthUserInput = Convert.ToDouble(Console.ReadLine());
                healthRemaning = (healthUserInput / maxHealthUserInput) * lengthBar;
                Console.Write("Введите строку расположения бара:");
                int position = Convert.ToInt32(Console.ReadLine());
                if(healthRemaning<0||healthRemaning>lengthBar)
                {
                    Console.Write("Введено некорректное количество здоровья! Повторите попытку.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if(position <= lineSpacing)
                {
                    Console.Write("Слишком близко к тексту!");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    DrawBar(healthRemaning, lengthBar, ConsoleColor.Red, position);
                    Console.ReadKey();
                    Console.Clear();
                    isWorkInput = false;
                }
            }
        }

        static void DrawBar(double value, double maxValue,ConsoleColor color,int position)
        {
            ConsoleColor defaultColor=Console.BackgroundColor;
            string bar = "";
            bool isWork = true;

            for (double i = 0; i < value; i++)
            {
                bar += " ";
            }

            Console.SetCursorPosition(0, position);
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;
            bar = "";

            for (double i = value; i < maxValue; i++)
            {
                bar += ' ';
            }

            Console.Write(bar + ']');
        }
    }
}