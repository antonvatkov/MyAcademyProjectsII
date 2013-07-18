/*
* Write a program that reads two arrays from the console and compares them element by element.
*/
using System;
class TwoArray
{
	public static void Main()
	{
		//allocates array
		
		Console.WriteLine("Enter the size of the first array");
		int oneSize=int.Parse(Console.ReadLine());
		int [] arrayOne = new int[oneSize];
		int element=0; //count the position
		
		//filling the array
		
		for (int i = 0; i < oneSize; i++)
		{
			element=i+1; // set counter "real" position (arrays are starting from 0 position to endPosition-1(array[5]->0 - 4)) 
			Console.WriteLine("Enter the {0} element of the array",element);
			arrayOne[i]=int.Parse(Console.ReadLine());
		}
		
		// the same scheme for the second array
		
		Console.WriteLine("Enter the size of the second array");
		int secondSize=int.Parse(Console.ReadLine());
		int [] arraySecond = new int[secondSize];
		
		element=0;
		for (int i = 0; i < secondSize; i++)
		{
			element=i+1;
			Console.WriteLine("Enter the {0} element of the second array",element);
			arraySecond[i]=int.Parse(Console.ReadLine());
		}
		
		//compare elements
		int counter=Math.Min(oneSize,secondSize);
		element=0;
		for (int i = 0; i < counter; i++) 
		{
			element=i+1;
			if (arrayOne[i]==arraySecond[i]) 
			{
				Console.WriteLine("Elements on position {0} are equal",element);
			}
			else
			{
				Console.WriteLine("Elements on position {0} are not equal: first array->{1} ; second array->{2}",element,arrayOne[i],arraySecond[i]);
			}
		}
		
		//system commands personal customization
		
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}
