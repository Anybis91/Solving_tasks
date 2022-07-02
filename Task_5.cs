using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "Иванов";
            String lastName = "Иван";
            Console.WriteLine($"Имя {name}, фамилия {lastName}. Что то напутал! Секунду....");
            String deltaName;
            deltaName = lastName;
            lastName = name;
            name = deltaName;
            Console.WriteLine($"Имя  {name} , фамилия  {lastName} . Сейчас верно!");
        }
    }
}
