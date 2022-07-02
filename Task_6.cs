using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Доброго дня покупатель! Хотите прикупить кристалов?! Напомню что в моей лавке 1 кристал по цене 42 золотых! А сколько у вас золота?");
            int goldPocket;
            goldPocket = Convert.ToInt32(Console.ReadLine());
            int cristalPrice = 42;
            int remainingGold;
            int cristalNum;
            cristalNum = goldPocket / cristalPrice;
            remainingGold = goldPocket % cristalPrice;
            Console.WriteLine("Могу продать вам " + cristalNum + " шт. И у вас останется " + remainingGold + " золота!");
        }
    }
}
