using System;

public class Program
{
	public static void Main()
	{
		int variableChange;
		int stepCycle=6;

		for (variableChange = 0; variableChange < 96; variableChange++)
		{
			if (variableChange == 5)
			{
				Console.WriteLine(variableChange);
			}
			else if(variableChange>=5)
			{
				variableChange = variableChange + stepCycle;
				Console.WriteLine(variableChange);
			}
			
		}
	}
} 