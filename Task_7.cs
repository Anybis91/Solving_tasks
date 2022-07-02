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
            int receptionTimePlayer = amountGrandmam * receptionTimeClient;
            int timeHour = 60;
            int timeMinute = 60;
            int timeWaitHour = receptionTimePlayer / timeHour;
            int timeWaitMinute = receptionTimePlayer % timeMinute;
            Console.WriteLine($"Вы должны отстоять в очереди {timeWaitHour} часа {timeWaitMinute} минут.");
        }
    }
}
