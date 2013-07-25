/*
*Write a method GetMax() with two parameters that returns the bigger of 
*two integers. Write a program that reads 3 integers 
*from the console and prints the biggest of them using the method GetMax(). 
*/
using System;
using System.Collections.Generic;
class GetMax
{
	public static int MaxValue (int i,int v)
	{
		return Math.Max(i,v);
	}
	public static void Main ()
	{
		int[] array = new int[3];
		for (int i = 0; i < 3; i++) 
		{
			Console.WriteLine("Please enter integer.");
			array[i] = int.Parse(Console.ReadLine());
		}
		int result1Max = MaxValue(array[0],array[1]);
		int result2Max = MaxValue(array[1],array[2]);
		Console.WriteLine("The bigger has values: {0}",MaxValue(result1Max,result2Max));
	}
}

