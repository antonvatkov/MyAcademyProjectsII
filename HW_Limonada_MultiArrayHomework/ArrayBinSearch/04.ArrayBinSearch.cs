/*
 * Write a program, that reads from the console an array
 * of N integers and an integer K, sorts the array using
 * the method Array.BinSearch() finds the largest number in the array
 * which is <=K.
 * 
 */
using System;
using System.Collections.Generic;
class ArrayBinSearch
{
	public static void Main()
	{
		Console.WriteLine(@"Please enter integer 'N'.");
		int n = int.Parse(Console.ReadLine());
		Console.WriteLine(@"Please enter integer 'K'.");
		int k = int.Parse(Console.ReadLine());
		int[] array = new int[]{23,1,2,3,4,56};
		//int[] array = new int[n];
		int index = 0;
		
		//for (int i = 0; i < n; i++)
		//{
		//	Console.WriteLine(@"Please enter integer number for array.");
		//	array[i] = int.Parse(Console.ReadLine());
		//}
		
		index = System.Array.BinarySearch(array, k);
		
		if (k < array[0])
		{
			Console.WriteLine("There is no number <= k");
		}
		else
		{
			if (index >= 0) 
			{
				Console.WriteLine(array[index]);
			}
			else
			{
				Console.WriteLine(array[~index - 1]);
			}
		}
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}
