using System;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Введите количество повторений:");
			int cycleAmount = Convert.ToInt32(Console.ReadLine()); ;
			Console.WriteLine("Введите сообщение:");
			String textUser = Console.ReadLine();
			Console.WriteLine("Цикл запущен:");
			for (int amountCycle= cycleAmount; amountCycle > 0; amountCycle--)
				{
				Console.WriteLine(textUser);
				}

		}
	}
}
