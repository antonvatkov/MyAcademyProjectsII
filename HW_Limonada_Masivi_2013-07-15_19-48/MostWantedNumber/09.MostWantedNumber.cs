/*
* Write a program that finds the most frequent number in an array. Example:
*{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)
*/
using System;
using System.Collections.Generic;
class MostWantedNumber
{
	public static void Main()
	{
		//parse the input data
		
		int[] array = new int[]{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3};
		Dictionary<int,int> mostWanted = new Dictionary<int, int>();
		int bestElement = 0;
		int bestFrequnecy = int.MinValue;
		
		for (int i = 0; i < array.Length; i++) 
		{
			int temp;
			if (mostWanted.TryGetValue(array[i],out temp)) 
			{
				mostWanted[array[i]] = temp + 1;
			}
			else
			{
				mostWanted.Add(array[i],1);
			}
		}
		
		foreach (var item in mostWanted) 
		{
			if (item.Value > bestFrequnecy) 
			{
				bestElement = item.Key;
				bestFrequnecy = item.Value;
			}
		}
		
		//print the result
		
		Console.Write(@" {0} ({1} times) )",bestElement,bestFrequnecy);
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}
