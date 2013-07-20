/*
 * We are given a matrix of strings of size N x M.
 * Sequances in the matrix we define as sets of several neihbor elements
 * located on the same line, column or diagonal. Write a program that finds
 * the longest sequance of equal strings in the matrix.
 * 
 */
using System;
using System.Collections.Generic;
class StringMatrix
{
	public static void LongestGet(string[,] array)
	{
		int maxCount = 0;
		string bestString = null;
		int[] dirRow = { 1, 0, 1, -1};
		int[] dirColl = { 0, 1, 1, 1};
		
		for (int row = 0; row < array.GetLength(0); row++)
		{
			for (int coll = 0; coll < array.GetLength(1); coll++) 
			{
				string current = array[row,coll];
				int currentCount = 1;
				
				//direction implement
				for (int direction = 0; direction < 4; direction++) 
				{
					int currentRow = row;
					int currentColl = coll;
					while (true) 
					{
						currentColl +=dirColl[direction];
						currentRow +=dirRow[direction];
						
						if (currentColl < 0 || currentColl >= array.GetLength(1) ||
						    currentRow < 0 || currentRow >= array.GetLength(0) ||
						    current != array[currentRow,currentColl]) 
						{
							break;	
						}
						
						currentCount++;
						
						if (currentCount >= maxCount) 
						{
							maxCount = currentCount;	
							bestString = current;
						}
					}
				}
			}
		}
		Console.WriteLine("The string is: {0} and it`s count {1} times.", bestString,maxCount);
	}
	
	public static void PrintMatrix(string[,] array)
	{
		for (int row = 0; row < array.GetLength(0); row++) 
		{
			for (int coll = 0; coll < array.GetLength(1); coll++) 
			{
				Console.Write(array[row,coll].PadLeft(4) + " ");
			}	
			Console.WriteLine();
		}
	}
	
	public static void Main()
	{
		//Console.WriteLine(@"Please enter integer number for 'N'.");
		//int n = int.Parse(Console.ReadLine());
		//Console.WriteLine(@"Please enter integer number for 'M'.");
		//int m = int.Parse(Console.ReadLine());
		//string[,] array = new string[m,n];
	
		//for (int row = 0; row < array.GetLength(0); row++) 
		//{
			//for (int coll = 0; coll < array.GetLength(1); coll++) 
			//{
			//	Console.WriteLine(@"Please enter element on {0} row {1}  coll",row,coll);
			//	array[row,coll] = Console.ReadLine();
			//}
		//}
		string[,] array = 
		{
			{"ha", "fifi","ho","hi"},
			{"fo", "ha", "hi", "xx"},
			{"xxx", "ho", "ha", "xx"},
		};
		PrintMatrix(array);
		LongestGet(array);
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}
