using System;

public class Program
{
	public static void Main()
	{
		int startNumber=0;
		int endNumber = 101;
		Random random = new Random();
		int randomNumber = random.Next(startNumber, endNumber);
		Console.WriteLine("Сгенерированное число = "+randomNumber);
		int multipleNumberOne = 3;
		int multipleNumberTwo = 5;
		int sumOfMultiplesOne=0;
		int sumOfMultiplesTwo=0;

		for (startNumber=0; startNumber <= randomNumber; startNumber++) 
		{
			if (startNumber % multipleNumberOne == 0)
			{
				sumOfMultiplesOne += startNumber;
			}
			else if (startNumber % multipleNumberTwo== 0)
			{
				sumOfMultiplesTwo += startNumber;
			}
		}

		int sumOfAllMultiplesNumber = sumOfMultiplesTwo + sumOfMultiplesOne;
		Console.WriteLine($"Сумма чисел кратны {multipleNumberOne} и {multipleNumberTwo} = {sumOfAllMultiplesNumber}");
	}
}