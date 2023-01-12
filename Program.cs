﻿using System;

namespace Task_29
{
    class Program
    {
        static void Main(string[] args)
        {
            double healthRemaning;
            double healthInBar;
            double lengthBar = 100;
            int percentagesInteger = 100;
            bool isWork = true;
            Console.Write("Введите максимальное количество здоровья:");
            double maxHealthUserInput = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите количество оставшегося здоровья:");
            double healthPersent = Convert.ToDouble(Console.ReadLine());
            healthRemaning = (healthPersent / maxHealthUserInput) *percentagesInteger;
            healthInBar = lengthBar * (healthRemaning / percentagesInteger);
            Console.Write("Введите строку расположения бара:");
            int position = Convert.ToInt32(Console.ReadLine());
            while(isWork)
            {
                if (position < 2)
                {
                    Console.Write("Слишком близко к тексту!");
                    isWork = false;
                }
                else
                {
                    DrawBar(healthInBar, lengthBar, ConsoleColor.Red, position);
                    Console.ReadKey();
                    Console.Clear();
                    isWork = false;
                }
            }
        }

        static void DrawBar(double value, double maxValue,ConsoleColor color,int position)
        {
            ConsoleColor defaultColor=Console.BackgroundColor;
            string bar = "";

            for(double i=0;i<value;i++)
            {
                bar += " "; 
            }

            Console.SetCursorPosition(0, position);
            Console.Write('[');
            Console.BackgroundColor=color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;
            bar = "";

            for(double i=value;i<maxValue;i++)
            {
                bar += ' ';
            }

            Console.Write(bar + ']');
        }
    }
}