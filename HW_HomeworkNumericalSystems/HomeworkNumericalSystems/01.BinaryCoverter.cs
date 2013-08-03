/* Write a program to convert decimal 
 * numbers to their binary representation.
 */
using System;
using System.Collections.Generic;
class BinaryCoverter
{
	public static void Print(List<int> binary)
	{
		foreach (var digit in binary) 
		{
			Console.Write(digit);
		}
	}
	public static void Main()
	{
		Console.WriteLine("Please enter an number.");
		int number = int.Parse(Console.ReadLine());
		List<int> binary = new List<int>();
		while (number > 0) 
		{
			binary.Add(number % 2);
			number = number /2;
		}
	
		binary.Reverse();
		Print(binary);
		
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}
