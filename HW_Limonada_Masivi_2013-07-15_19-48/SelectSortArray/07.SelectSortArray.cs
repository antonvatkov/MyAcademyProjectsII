/*
* Sorting an array means to arrange its elements in increasing order. 
* Write a program to sort an array. Use the "selection sort" algorithm:
*  Find the smallest element, move it at the first position,
*  find the smallest from the rest, move it at the second position, etc.
*/
using System;
class SelectSortArray
{
	public static void Main()
	{
		Console.WriteLine("Test array is: {9,8,6,5,4,3,7,2,1}.");
		Console.WriteLine("Press any key to continue . . . ");
		Console.ReadKey(true);
		int [] array = new int[]{9,8,6,5,4,3,7,2,1};

		for (int i = 0; i < array.Length-1; i++) 
		{
			int minValue=i;
			for (int v = i+1; v < array.Length; v++) 
			{
				if (array[v] < array[minValue])
				{
					minValue=v;
				}
			}
			
			if (minValue!=i) 
			{
				int temp=0;
				temp=array[i];
				array[i]=array[minValue];
				array[minValue]=temp;
			}
		}
		
		//print sorted array
		for (int i = 0; i < array.Length; i++) 
		{
			Console.Write("{0}  ",array[i]);
		}
		//system commands personal customization
		Console.WriteLine();
		Console.WriteLine("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}
