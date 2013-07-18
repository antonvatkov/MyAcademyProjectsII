/*
* Write a program that finds the sequence of maximal sum in given array. Example:
*{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
*Can you do it with only one loop (with single scan through the elements of the array)?
*/
using System;
class MaxSumArray
{
	public static void Main()
	{
		int [] array = new int[]{2, 3, -6, -1, 2, -1, 6, 4, -8, 8};
		
		string sequanceKeeper=null;
		string sequanceBuild=null;
		int currentSum=0;
		int maxSum=0;
		
		for (int i = 0; i < array.Length; i++) 
		{
			currentSum+=array[i];
			sequanceBuild+=array[i].ToString()+",";
			if (currentSum>maxSum)
			{
				maxSum=currentSum;
				sequanceKeeper=sequanceBuild;
			}	
		
			if (currentSum<0) 
			{
				currentSum=0;
				sequanceKeeper=null;
			}
		}
		
		Console.WriteLine("The best sequance is: {0} .The best sum is: {1}.",sequanceKeeper,maxSum);
		
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}
