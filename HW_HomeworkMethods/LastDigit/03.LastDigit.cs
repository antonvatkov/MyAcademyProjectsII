/*
 * Write a method that returns the last digit of given integer as an English word.
 * Examples: 512  "two", 1024  "four", 12309  "nine".
 */
using System;
class LastDigit
{
	public static void PrintWordDigit (int digit)
	{
		switch (digit) 
		{
		case 1:
			Console.Write("one");
			break;
		case 2:
			Console.Write("two");
			break;
		case 3:
			Console.Write("three");
			break;
		case 4:
			Console.Write("four");
			break;
		case 5:
			Console.Write("five");
			break;
		case 6:
			Console.Write("six");
			break;
		case 7:
			Console.Write("seven");
			break;
		case 8:
			Console.Write("eight");
			break;
		case 9:
			Console.Write("nine");
			break;
		case 0:
			Console.Write("zero");
			break;
		default:
			Console.Write("Wrong input");
			break;
		}
	}
	public static void Main ()
	{
		Console.WriteLine ("Please enter a integer number.");
		int number = int.Parse(Console.ReadLine());
		int lastDigit = number % 10;
		Console.WriteLine("The number is : {0} and the last number in English text is: ",number);
		PrintWordDigit(lastDigit); 	
	}
}

