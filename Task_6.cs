using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int cristalPrice = 42;
            Console.WriteLine($"Доброго дня покупатель! Хотите прикупить кристалов?! Напомню что в моей лавке 1 кристал по цене {cristalPrice} золотых! А сколько у вас золота?");
            int goldPocket;
            goldPocket = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сколько кристалов желаете приобрести?");
            int cristalAmount;
            cristalAmount = Convert.ToInt32(Console.ReadLine());
            goldPocket = goldPocket-(cristalAmount*cristalPrice);
            Console.WriteLine($"Вы купили {cristalAmount} кристалов, у вас осталось {goldPocket} золота.");


        }
    }
}
