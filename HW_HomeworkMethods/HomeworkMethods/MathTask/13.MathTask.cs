/*
* Write a program that can solve these tasks:
*Reverses the digits of a number
*Calculates the average of a sequence of integers
*Solves a linear equation a * x + b = 0
*Create appropriate methods.
*Provide a simple text-based menu for the user to choose which task to solve.
*Validate the input data:
*The decimal number should be non-negative
*The sequence should not be empty
*a should not be equal to 0
*/
using System;
using System.Text;
class MathTask
{
	public static string DigitReverse(string digit)
    {
        StringBuilder reversDigit = new StringBuilder();
        for (int i = digit.Length - 1 ; i >= 0;i --)
        {
            reversDigit.Append(digit[i]);
        }
        return reversDigit.ToString();
    }
	public static int AverageArraySolver(int[] array)
	{
		int sum = 0;
		for (int i = 0; i < array.Length; i++) 
		{
			sum+=array[i];
		}
	return sum/array.Length;
	}
	public static decimal LinearSolver(decimal variableA,decimal variableB)
	{
		decimal result = -(variableB/variableA);
		return result;
	}
	public static void MenuSolver(int choice )
	{
		switch (choice) 
		{
			case 1 :
			Console.WriteLine("Please insert a number.");
        	string digit = Console.ReadLine();
   		 	Console.WriteLine(DigitReverse(digit));
			break;
			case 2 :
			Console.WriteLine(@"Please enter parameter 'a'.");
			decimal variableA = int.Parse(Console.ReadLine());
			Console.WriteLine(@"Please enter parameter 'b'.");
			decimal variableB = int.Parse(Console.ReadLine());
			Console.WriteLine(LinearSolver(variableA,variableB));
			break;
			case 3 :
			Console.WriteLine("Please enter length of the array.");
			int length = int.Parse(Console.ReadLine());
			Console.WriteLine("Please enter length of the array.");
			int[] array = new int[length];
			for (int i = 0; i < length; i++) 
			{
				array[i] = int.Parse(Console.ReadLine());
			}
			Console.WriteLine(AverageArraySolver(array));
			break;
			default:
			Console.WriteLine("Wrong input!");
			Main();
			break;
		}
	}
	public static void Main ()
	{
		Console.WriteLine("Menu Task");
		Console.WriteLine("OPTIONS LIST:");
		Console.WriteLine("1.Reverses the digits of a number.");
		Console.WriteLine("2.Solves a linear equation a * x + b = 0");
		Console.WriteLine("3.Calculates the average of a sequence of integers");
		Console.WriteLine("System is ready please enter for choice.");
		int choice = int.Parse(Console.ReadLine());
		MenuSolver(choice);
		Console.WriteLine("Have a nice day :) .");
		Console.ReadKey(true);
	}
}