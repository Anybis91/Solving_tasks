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
            int minutesInHour = 60;
            int timeWaitHour = receptionTimePlayer / minutesInHour;
            int timeWaitMinute = receptionTimePlayer % minutesInHour;
            Console.WriteLine($"Вы должны отстоять в очереди {timeWaitHour} часа {timeWaitMinute} минут.");
        }
    }
}
