using System;

namespace Task_18
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            char leftBracket = '(';
            char rightBracket = ')';
            Console.WriteLine("Введите строку из символов '(' и ')'.");
            userInput = Console.ReadLine();
            int valueLeftBracket = +1;
            int valueRightBracket = -1;
            int numberBracketsFullExpression = 0;
            int maxDeepBracket=0;

            foreach (var ch in userInput)
            {
                if (ch == leftBracket)
                {
                    numberBracketsFullExpression += valueLeftBracket;

                    if(numberBracketsFullExpression > maxDeepBracket)
                    {
                        maxDeepBracket = numberBracketsFullExpression;
                    }
                }
                else if (ch == rightBracket)
                {
                    numberBracketsFullExpression += valueRightBracket;
                }
            }

            if (numberBracketsFullExpression == 0)
            {
                Console.WriteLine($"Строка {userInput} корректная, максимальная глубина выражения {maxDeepBracket}");
            }
            else 
            {
                Console.WriteLine($"Строка {userInput} некорректна");
            }
        }
    }
}