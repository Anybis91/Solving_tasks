using System;

namespace Task_Queue_at_the_store
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int marketWallet=0;
            bool isWork = true;
            Queue<int> buyers = new Queue<int>();
            buyers.Enqueue(112);
            buyers.Enqueue(532);
            buyers.Enqueue(1246);
            buyers.Enqueue(763);
            buyers.Enqueue(2133);
            buyers.Enqueue(65);
            buyers.Enqueue(383);
            
            while(isWork)
            {
                if(buyers.Count == 0)
                {
                    Console.WriteLine($"В очереди больше нет покупателей!\nВыручка магазина составила: {marketWallet}");
                    isWork=false;
                }
                else
                {
                    Console.WriteLine($"Общая выручка магазина: {marketWallet}");
                    Console.WriteLine("Сумма вашей покупки: " + buyers.Peek());
                    marketWallet += buyers.Dequeue();
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}