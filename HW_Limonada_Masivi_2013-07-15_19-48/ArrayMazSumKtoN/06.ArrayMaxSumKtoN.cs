/*
* Write a program that reads two integer numbers N and K and an array of N elements from the console.
*  Find in the array those K elements that have maximal sum.
*/
using System;
class ArrayMaxSumKtoN
{
	public static void Main()
	{
		//Parse input
		
		Console.WriteLine("Please enter N (size of the array).");
		int arraySize =int.Parse(Console.ReadLine());
		
		int [] array = new int[arraySize];
		
		//test
		//int [] array = new int[]{2,3,4,5,6,7,5};
		
		Console.WriteLine("Please enter K (elements).");
		int variableK = int.Parse(Console.ReadLine());
		
		for (int i = 0; i < array.Length; i++)
		{
		Console.WriteLine("Please enter elements.");
		array[i]=int.Parse(Console.ReadLine());
		}
		
		int sum=0;
		int maxSum=0;
		string currentSequance=null;
		string resultSequance=null;
		int lenght=array.Length;
		
		for (int i = 0; i < lenght; i++) 
		{
			if (i+variableK>array.Length) 
			{
				break;	
			}	
			
			for (int v = i; v < i+variableK; v++) 
			{
				sum+=array[v];
				currentSequance=currentSequance+' '+array[v];
			
			}
			if (sum>maxSum)
			{
				maxSum=sum;
				resultSequance=currentSequance;						
			}
		sum=0;	
		currentSequance=null;
		}
		
		//print result
		
		Console.WriteLine("Sequance is: {0} .Sum is {1}.",resultSequance,maxSum);
		
		//system commands personal customization
		
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}
