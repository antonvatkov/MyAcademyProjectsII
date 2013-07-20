/*
 * Write a program that fills and print amatrix of size
 * (n, n) as shown below : (examples for n = 4)
 * 
 */
using System;
using System.Collections.Generic;
class FillPrintMatrix
{
	public static void PrintArray(int[,] array)
	{
		for (int i = 0; i < array.GetLength(0); i++) 
		{
			for (int v = 0; v < array.GetLength(1); v++) 
			{
				Console.Write(array[i,v].ToString().PadLeft(2) + " ");
			}	
		Console.WriteLine();
		}
	}
	
	public static int[,] GetTypeA(int n)
	{
		Console.WriteLine(@"This is tipe 'A' ");
		int[,] array = new int[n,n];
		int numericStartValue = 1;
		for (int coll = 0; coll < n; coll++) 
		{
			for (int row = 0; row < n; row++,numericStartValue++)
			{
				array[row,coll] = numericStartValue;
			}
		}
		return array;
	}
	
	public static int[,] GetTypeB(int n)
	{
		Console.WriteLine(@"This is tipe 'B' ");
		int[,] array = new int[n,n];
		int numericStartValue = 1;
		for (int coll = 0; coll < n; coll++) 
		{
			if (coll%2 == 0) 
			{
				for (int row = 0; row < n; row++,numericStartValue++)
				{
					array[row,coll] = numericStartValue;
				}
			}
			else
			{
				for (int row = n - 1 ; row >= 0; row--,numericStartValue++)
				{
					array[row,coll] = numericStartValue;
				}
			}
		}
		return array;
	}
	
	public static int[,] GetTypeC(int n)
	{
		Console.WriteLine(@"This is tipe 'C' ");
		int[,] array = new int[n,n];
		int startRow = n - 1;
		int startColl = 0;
		
		for (int i = 1; i <= (n * n); i++)
		{
			array[startRow++,startColl++] = i;
			
			if ((startRow == n)||(startColl == n)) 
			{
				startRow--;
				if (startColl == n) 
				{
					startRow--;
					startColl--;
				}
				while((startRow - 1 >= 0) && (startColl - 1 >= 0))
				{
					startRow--;
					startColl--;
				}
			}
		}
		return array;
	}
	
	public static int[,] GetTypeD(int n)
	{
		Console.WriteLine(@"This is tipe 'D' ");
        int[,] array = new int[n, n];
        int ending = n;
        int start = 0;
        int counter = 1;
        do
        {
            for (int i = start; i < ending; i++)
            {
                array[i, start] = counter;
                counter++;
            }

            for (int j = start + 1; j < ending; j++)
            {
                array[ending - 1, j] = counter;
                counter++;
            }

            for (int k = ending - 2; k >= start; k--)
            {
                array[k, ending - 1] = counter;
                counter++;
            }

            for (int p = ending - 2; p >= start + 1; p--)
            {
                array[start, p] = counter;
                counter++;
            }

            start++;
            ending--;
        }
        while (ending - start > 0);
		return array;
	}
	 public static void Main()
	{
	 	Console.WriteLine("Please enter a integer.");
	 	int n = int.Parse(Console.ReadLine());
		PrintArray(GetTypeA(n));
		PrintArray(GetTypeB(n));
		PrintArray(GetTypeC(n));
		PrintArray(GetTypeD(n));
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}
