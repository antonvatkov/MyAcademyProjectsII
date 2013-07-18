/*
* Write a program that finds the index of given element in a sorted 
* array of integers by using the binary search algorithm (find it in Wikipedia).
*/
using System;
class BinarySearchArray
{
	public static void Main()
	{
		int[] array = new int[]{3,2,1,9,8,7,6,5,4};
		Array.Sort(array);
		int key = 5;
		int min = 0;
		int max = array.Length;
		int result = 0;
		
		while (min < max) 
		{
			int mid = (min+max)/2;
			if (array[mid] < key)
			{
				min = mid + 1;
			}
			else if (array[mid] > key) 
			{ 
				max = mid - 1;
			}
			else
			{
				result=mid;
				break;
			}
		}
		Console.Write("Index of element '5' is: {0} ",result);
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}
