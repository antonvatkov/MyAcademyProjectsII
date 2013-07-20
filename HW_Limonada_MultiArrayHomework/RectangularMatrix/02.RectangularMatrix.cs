/*
 * Write a program that reads a rectangular matrix of size 
 * N x M and finds in it the square 3 x 3 that has maximal 
 * sum of its elements.
 * 
 */
using System;
using System.Collections.Generic;
class RectangularMatrix
{
	public static void PrintResult(int[,] array)
	{
		for (int rows = 0; rows < array.GetLength(0); rows++) 
		{
			for (int colls = 0; colls < array.GetLength(1); colls++) 
			{
				Console.Write(array[rows,colls]);
			}
		Console.WriteLine();
		}
	}
	
	public static void GetSum(int[,] array)
	{
		int maxSum = 0;
		
		for (int row = 0; row < array.GetLength(0) - 3 + 1; row++)
		{
			for (int coll = 0; coll < array.GetLength(1) -3 + 1; coll++) 
			{
				int sum = 0;
				for (int rows = row; rows < row + 3; rows++) 
				{
					for (int colls = coll; colls < coll + 3; colls++) 
					{
						sum += array[rows,colls];
					}
				}
				
				if (maxSum <= sum) 
				{
					maxSum = sum;	
				}
			}	
		}		
		Console.WriteLine("Maximal sum of its elements is: {0}",maxSum);
	}
	
	public static void Main()
	{
		Console.WriteLine(@"Please enter 'N'.");
		int n = int.Parse(Console.ReadLine());
		Console.WriteLine(@"Please enter 'M'.");
		int m = int.Parse(Console.ReadLine());
		int[,] array = new int[n,m];
		
		for (int row = 0; row < array.GetLength(0) ; row++) 
		{
			for (int coll = 0; coll < array.GetLength(1); coll++) 
			{
				Console.WriteLine(@"Please enter element on {0} row {1}  coll",row,coll);
				array[row,coll]=int.Parse(Console.ReadLine());
			}
		}
		PrintResult(array);
		Console.WriteLine();
		GetSum(array);
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}
