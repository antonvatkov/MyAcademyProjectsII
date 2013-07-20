/*
* You are given an array of strings.Write a method
* that sorts the array by the length of its 
* elements (the number of characters composing them).
* 
*/
using System;
using System.Collections.Generic;
class LengthArraySort
{
	public static void Main()
	{
		string[] array = new string[]{"a","ab","abbaab","abc","abcd"};
		int[] lengthString = new int[array.Length];
		for (int i = 0; i < array.Length; i++) 
		{
			int length = array[i].Length;
			lengthString[i] = length;
			
		}
		//string[] sortedArray = new string[array.Length];
		Array.Sort(lengthString, array );
		
		
		
		foreach (var item in array)
        {
            Console.WriteLine(item);
        }
		
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}
