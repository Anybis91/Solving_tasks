using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как тебя зовут ?");
            String name;
            name = Console.ReadLine();
            Console.WriteLine("Сколько тебе лет ?");
            String age;
            age = Console.ReadLine();
            Console.WriteLine("Где ты живёшь ?");
            String city;
            city = Console.ReadLine();
            Console.WriteLine("Кем ты работаешь?");
            String job;
            job = Console.ReadLine();
            Console.WriteLine($"Привет {name}! Я знаю что ты живешь в {city}, хорошее место." +
                $" Получается что ты работаешь {job} в свои {age} лет. Это интересно.");
        }
    }
}
