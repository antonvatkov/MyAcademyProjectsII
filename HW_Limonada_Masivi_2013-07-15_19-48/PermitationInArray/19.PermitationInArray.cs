/*
*Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N]. Example:
*	n = 3  {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}
*/
using System;
using System.Collections.Generic;
class PermitationInArray
{
	public static void Main(string[] args)
	{
		List<string> myString = new List<string>{"a", "b", "c", "d", "f"};
		List<string> result = new List<string> ();
		for (int i = 0; i < myString.Count; i++)
		{
		    for (int j = 0; j < myString.Count; j++)
		    {
		        if (i == j)
		        {
	        		continue;
		        }
		            
		        result.Add(myString[i] + myString[j]);
		    }
		}
		
		foreach (var item in result) 
		{
			Console.WriteLine(item);
		}
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}
