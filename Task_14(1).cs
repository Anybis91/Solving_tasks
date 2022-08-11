using System;

namespace Task_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInputName;
            char userInputSymbol;
            int borderNumber = 2;
            Console.WriteLine("Введите имя:");
            userInputName = Console.ReadLine();
            Console.WriteLine("Введите символ:");
            userInputSymbol = Convert.ToChar(Console.ReadLine());
            string convertSymbol = Convert.ToString(userInputSymbol);
            int numberSymbols = (userInputName.Length) + borderNumber;
            Console.WriteLine("Результат:");
            string border="";

            for (int j = 0; j < numberSymbols; j++)
            {
                border += convertSymbol;
            }

            string twoLineName = convertSymbol + userInputName + convertSymbol;
            Console.WriteLine(border+"\n"+twoLineName+"\n"+ border);
        }
    }
}
