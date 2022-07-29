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
            Console.WriteLine("Введите слово:");
            userInputName = Console.ReadLine();
            Console.WriteLine("Введите символ:");
            userInputSymbol= Console.ReadLine();
            numberSymbols = (userInputName.Length)+2;
            Console.WriteLine(numberSymbols);
            Console.WriteLine("Результат:");

            for (int j = 0; j < 1; j++)
            {
                Console.WriteLine(userInputSymbol);
                Console.WriteLine(userInputSymbol+ userInputName + userInputSymbol);
                Console.WriteLine(userInputSymbol);
            }
        }
    }
}
