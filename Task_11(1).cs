using System;

public class Program
{
	public static void Main()
	{
		int startNumber = 0;
		int endNumber = 101;
		Random random = new Random();
		int randomNumber = random.Next(startNumber, endNumber);
		Console.WriteLine("Сгенерированное число = "+randomNumber);
		int multipleNumberOne = 3;
		int multipleNumberTwo = 5;
		int sumOfMultiplesOne=0;
		int sumOfMultiplesTwo=0;

		while (startNumber<= randomNumber) 
		{
			if (startNumber % multipleNumberOne == 0)
			{
				sumOfMultiplesOne += startNumber;
			}
			else if (startNumber % multipleNumberTwo== 0)
			{
				sumOfMultiplesTwo += startNumber;
			}
			startNumber++;
		}
		int sumOfAllMultiplesNumber = sumOfMultiplesTwo + sumOfMultiplesOne;
		Console.WriteLine("Сумма чисел кратны 3 и 5  = " + sumOfAllMultiplesNumber);
	}
}