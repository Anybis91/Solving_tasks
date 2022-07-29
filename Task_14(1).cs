using System;

namespace Task_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInputName;
            string userInputSymbol;
            int numberSymbols;
            Console.WriteLine("Введите имя:");
            userInputName = Console.ReadLine();
            Console.WriteLine("Введите символ:");
            userInputSymbol= Console.ReadLine();
            numberSymbols = (userInputName.Length)+2;
            Console.WriteLine("Результат:");

            for (int j = 0; j < numberSymbols; j++)
            {
                Console.Write(userInputSymbol);
            }

            Console.WriteLine($"\n{userInputSymbol}{userInputName}{userInputSymbol}");

            for (int j = 0; j < numberSymbols; j++)
            {
                Console.Write(userInputSymbol);
            }
        }
    }
}
