/*
* Write a program that allocates array of 20 integers and initializes 
* each element by its index multiplied by 5. Print the obtained array on the console.
*/
using System;
class HomeArray
{
	public static void Main()
	{
		//allocates array
		int arraySize=20;
		int variable=5;
		int [] array = new int [arraySize];
		
		//initializes each element by its index multiplied by 5
		
		for (int i = 0; i < arraySize; i++)
		{
			array[i] = (i+1) * variable;
		}
		
		//print array
		
		for (int v = 0; v < arraySize; v++) 
		{
			Console.WriteLine(array[v]);
		}
		
		//system commands personal customization
		
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}
