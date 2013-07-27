/*
* Write a method that return the maximal
* element in a portion of array of integers starting at
* given index. Using it write another method that sorts 
* an array in ascending / descending order.
*/ 
using System;
class MaxElementReturnArray
{
	public static int MaxGet(int[] array,int position )
	{
		int biggest = position;
		for (int i = position; i < array.Length; i++) 
		{
			if (array[i] > array[position]) 
			{
				biggest = i;
			}
		}
	return biggest;
	}
	
	public static int[] SelectionSort(int[] array, bool assending)
	{
		for (int i = 0; i < array.Length; i++) 
		{
			int max = MaxGet(array, i);
			Swap(array,i,max);
		}
		
		if (assending) 
		{
			Array.Reverse(array);
		}
	return array;
	}
	public static void Swap(int[] array,int elementA,int elementB)
	{
		for (int i = 0; i < array.Length; i++) 
		{
			int temp = array[elementA];
			array[elementA] = array[elementB];
			array[elementB] = temp;
		}
	}
	public static void Main ()
	{
		int[] array = new int[10]{1,2,3,4,5,6,7,8,9,0};
		Console.WriteLine("Max element in a portin if array");
		Console.WriteLine(array[MaxGet(array,4)]);
        Console.WriteLine("Selection sort");
        array = SelectionSort(array,true);
        
        foreach (var element in array) 
        {
        	Console.Write("{0}",element);
        }
        Console.ReadKey(true);
	}
} 

