/*
* Write a method that adds two polynomials. 
* Represent them as arrays of their coefficients 
* as in the example below:
*x2 + 5 = 1x2 + 0x + 5 
*/
using System;
using System.Collections.Generic;
using System.Text;
class PolinomialSum
{
	public static void PollyAdd(int[] polX,int[] polY)
	{
		List<int> finalPol = new List<int>();
		
		if (polX.Length >= polY.Length) 
		{
			for (int i = 0; i < polX.GetLength(0); i++) 
			{
				finalPol.Add(polX[i] + polY[i]);
			}	
		}
		else
		{
			for (int i = 0; i < polY.Length; i++) 
			{
				finalPol.Add(polX[i] + polY[i]);
			}
		}
		
		StringBuilder result = new StringBuilder();
		
		if (finalPol[0] != 0)
		{
			result.AppendFormat("{0} ", finalPol[0]);
		}
		
		for (int i = 1; i < finalPol.Count; i++) 
		{
			if ((finalPol[i] !=0) && (finalPol[i] > 0)) 
			{
				result.AppendFormat("+ {0}^x{1} ",finalPol[i],i);
			}	
			
			if (finalPol[i] < 0)
			{
				result.AppendFormat("+ {0}^x{1} ",finalPol[i],i);
			}
		}
		Console.WriteLine(result.ToString());
	}
		public static void Main ()
	{
			int[] polinomX = {3, -1, 2};
			int[] polinomY = {4,-2, 2};
	
			PollyAdd(polinomX,polinomY);
			Console.ReadKey(true);
	}
}