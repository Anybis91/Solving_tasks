using System;

public class Program
{
	public static void Main()
	{
		int variableChange;
		int stepCycle=7;

		for (variableChange=5; variableChange < 100; variableChange = variableChange + stepCycle)
		{
			Console.WriteLine(variableChange);
		}
	}
} 