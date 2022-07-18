using System;

public class Program
{
	public static void Main()
	{
		int variableChange;// нам необходима последовательность цифр 5 12 19 26 33 40 47 54 61 68 75 82 89 96 следовательно переменная будет меняться

		for (variableChange = 5; variableChange < 101; variableChange += 7)// переменная задается = 5 чтобы упростить подсчет,
																		   //использован цикл for так как будет определенное колличество итераций цикла, при каждом цикле наша переменная будет увеличина на 7
		{
			Console.WriteLine(variableChange);
		}
	}
}