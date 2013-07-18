/*
* Write a program that creates an array containing all letters from the alphabet (A-Z).
*  Read a word from the console and print the index of each of its letters in the array.
*/
using System;
class ArrayFullOfLetters
{
	public static void Main()
	{
		int[] letterArray = new int[53];
		
		for (int i = 1; i < (letterArray.Length / 2) + 1; i++) 
		{
			letterArray[i] = ('a' - 1) + i;
		}
		for (int i = (letterArray.Length /2) + 1,v = 0; i < letterArray.Length; i++, v++) 
		{
			letterArray[i] = ('A' + v);
		}
		
		string testString = "Pizza";
		for (int i = 0; i < testString.Length; i++) 
		{
			for (int v = 0; v < letterArray.Length; v++) 
			{
				if (testString[i] == letterArray[v]) 
				{
					Console.WriteLine("letter is: {0} index is: {1}",testString[i],v);
					break;
				}
			}
		}
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}
