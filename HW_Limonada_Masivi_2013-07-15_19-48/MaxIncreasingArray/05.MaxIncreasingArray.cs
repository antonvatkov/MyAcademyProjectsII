/*
* Write a program that finds the maximal increasing sequence in an array. Example: 
*{3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.
*/
using System;
class MaxIncreasingArray
{
	public static void Main()
	{
		int [] array = new int[]{3, 2, 3, 4, 2, 2, 4};
		
		int lenght=1;
		int maxLenght=0;
		int endIndex=0;
		for (int i = 0; i < array.Length-1; i++) 
		{
			if (array[i]<array[i+1]) 
			{
				lenght++;	
			}
			else
			{
				if (lenght>maxLenght) 
				{
					maxLenght=lenght;	
					endIndex=i;
				}
			lenght=1;
			}
		}
		//special case
		if (lenght>maxLenght) 
		{
			maxLenght=lenght;
			endIndex=array.Length-1;			
		}
		lenght=1;
		//print the sequance
		
		Console.Write("{");
		for (int i = endIndex-maxLenght+1; i < endIndex+1; i++) 
		{
			Console.Write("{0}",array[i]);
		}
		Console.Write("}");
		//system commands personal customization
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}
