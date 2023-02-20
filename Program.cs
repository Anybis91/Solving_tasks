using System;

namespace Task_Explanatory_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isWork = true;
            string exitCommand = "exit";
            Dictionary<string, string> explanatoryDictionary = new Dictionary<string, string>();
            explanatoryDictionary.Add("Абориген", "Коренной житель страны, местности.");
            explanatoryDictionary.Add("Яблоко", "Плод яблони.Простой нижний синкарпный сочный многосемянный плод, в образовании которого кроме завязи принимают участие цветоложе и сильно разросшаяся и сросшаяся с завязью цветочная трубка.");
            explanatoryDictionary.Add("Гусли", "Русский струнный щипковый инструмент, в зависимости от количества струн — от 5-9 до 55-66 — различались крыловидные, звончатые; шлемо-видные и прямоугольные, стопообразные.");
            explanatoryDictionary.Add("Автомобиль", "Самоходная транспортная машина, обычно на колёсном (реже полугусеничном) ходу, приводимая в движение собственным двигателем.");
            explanatoryDictionary.Add("Вексель", "Документ, составленный с соблюдением предписанных форм и воплощающий в себе срочное денежное обязательство.");
            explanatoryDictionary.Add("Деньги", "В обширном смысле могут быть названы всякие знаки ценности, служащие для размена, для приобретения других предметов, для покупки или найма человеческого труда.");


            while (isWork)
            {
                Console.WriteLine($"Введите слово, или {exitCommand} для выхода ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                string userinput = Console.ReadLine();
                

                if (userinput == exitCommand)
                {
                    isWork = false;
                }
                else if (explanatoryDictionary.ContainsKey(userinput))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(explanatoryDictionary[userinput]+"\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.WriteLine("Такого слова пока нет в базе!\n");
                }
            }
        }
    }
}