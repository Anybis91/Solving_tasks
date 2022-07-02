using System;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во старушек: ");
            int amountGrandmam;
            amountGrandmam = Convert.ToInt32(Console.ReadLine());
            int receptionTimeClient = 10;
            int timeWaitHour;
            timeWaitHour = (amountGrandmam * receptionTimeClient) / 60;
            int timeWaitMin;
            timeWaitMin = (amountGrandmam * receptionTimeClient) % 60;
            Console.WriteLine("Вы должны отстоять в очереди " + timeWaitHour + " часа " + timeWaitMin + " минут.");
        }
    }
}
