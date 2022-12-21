using System;

namespace Task_29
{
    class Program
    {
        static void Main(string[] args)
        {
            double health = 4;
            double maxHealth = 10;

            Console.Write("Введите количество оставшегося здоровья в %:");
            double healthPersent = Convert.ToDouble(Console.ReadLine());
            health = (maxHealth / 100) * healthPersent;
            Console.Write("Введите строку расположения бара:");
            int position = int.Parse(Console.ReadLine());
            DrawBar(health, maxHealth, ConsoleColor.Red, position);
            Console.ReadKey();
            Console.Clear();
        }

        static void DrawBar(double value, double maxValue,ConsoleColor color,int position)
        {
            ConsoleColor defaultColor=Console.BackgroundColor;
            string bar = "";

            for(double i=0;i<value;i++)
            {
                bar += ' '; 
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