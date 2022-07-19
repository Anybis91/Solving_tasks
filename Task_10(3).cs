using System;

public class Program
{
	public static void Main()
	{
		int variableChange;
		int stepCycle=7;
		int startCycleNumber = 5;
		int endCycleNumber = 100;

		for (variableChange=startCycleNumber; variableChange < endCycleNumber; variableChange = variableChange + stepCycle)
		{
			Console.WriteLine(variableChange);
		}
	}
} 