/*
* Write a program 
* that finds in given array of integers a sequence of given sum S 
* (if present). Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}
*/
using System;
using System.Text;
class SequanceOfSumInArray
{
	public static void Main()
	{
		//parse the input data
		
		int s = 11;											//int.Parse(Console.ReadLine());
		int[] array = new int[]{4, 3, 1, 4, 2, 5, 8};
		string sequance = null;
		StringBuilder sequanceBuild = new StringBuilder();
		
		for (int i = 0; i < array.Length; i++) 
		{
			int sum = 0;
			for (int j = i; j < array.Length; j++) 
			{
				sum+=array[j];
				sequanceBuild.AppendFormat("{0}, ",array[j]);
				if (sum > s) 
				{
					sequanceBuild.Clear();
					sum = 0;
					break;
				}
				
				if (sum == s) 
				{
					sequance = sequanceBuild.ToString();
					Console.Write(@"S={0} -> ( {1})",s,sequance);
				}
			}
		}
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}
