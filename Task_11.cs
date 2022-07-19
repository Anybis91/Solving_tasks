using System;

public class Program
{
	public static void Main()
	{
		Random rand = new Random();
		int number = rand.Next(0, 101);
		Console.WriteLine(number);
		int multipleNumberOne = 3;
		int multipleNumberTwo = 5;
		int amountNumberOne = number / multipleNumberOne;
		int amountNumberTwo = number / multipleNumberTwo;
		Console.WriteLine("Колличество положительных чисел кратных " + multipleNumberOne + " от числа " + number + ", равно " + amountNumberOne);
		Console.WriteLine("Колличество положительных чисел кратных " + multipleNumberTwo + " от числа " + number + ", равно " + amountNumberTwo);
		float sumAllNumberOne = ((multipleNumberOne + (multipleNumberOne * amountNumberOne)) / 2) * amountNumberOne;
		float sumAllNumberTwo = ((multipleNumberTwo + (multipleNumberTwo * amountNumberTwo)) / 2) * amountNumberTwo;
		Console.WriteLine("Сумма всех положительных чисел кратных " + multipleNumberOne + " от числа " + number + ", равно " + sumAllNumberOne);
		Console.WriteLine("Сумма всех положительных чисел кратных " + multipleNumberTwo + " от числа " + number + ", равно " + sumAllNumberTwo);
	}
}