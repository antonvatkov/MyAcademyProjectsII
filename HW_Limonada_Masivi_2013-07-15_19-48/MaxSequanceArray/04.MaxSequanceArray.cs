/*
* Write a program that finds the maximal sequence of equal elements in an array.
*	Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.
*/
using System;
class MaxSequanceArray
{
	public static void Main()
	{
		//allocates array
		
		int [] sequance = new int[]{2, 1, 1, 2, 3, 3, 2, 2, 2, 1};
	
		int variableForLenght=1;
		int variableForBestLenght=0;
		int variableToKeepBestLenghtValue=0;
		
		for (int i = 0; i < sequance.Length-1; i++) 
		{
			if (sequance[i]==sequance[i+1])
			{
				variableForLenght++;
			}
			else
			{
				if (variableForLenght>variableForBestLenght) 
				{
					variableForBestLenght=variableForLenght;
					variableToKeepBestLenghtValue=sequance[i];
				}
			variableForLenght=1;
			}
		}
		// Special case
		if (variableForLenght>variableForBestLenght) 
		{
			variableForBestLenght=variableForLenght;
			variableToKeepBestLenghtValue=sequance[sequance.Length-1];
		}
		
		Console.WriteLine("Maximun sequance is :{0} lenght of the element {1}",variableForBestLenght,variableToKeepBestLenghtValue);
		//system commands personal customization
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}