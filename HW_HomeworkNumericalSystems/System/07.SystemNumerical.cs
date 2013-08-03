/* Write a program to convert decimal 
 * numbers to their binary representation.
 */
using System;
using System.Text;
using System.Collections.Generic;
class SystemNumerical
{
	public static void Main()
	{
		Console.WriteLine("Please enter an number.");
		string number = Console.ReadLine();
		int baseX = 2;
		int baseY = 16;
		
		StringBuilder reversing = new StringBuilder();
		
		for (int i = number.Length - 1; i >= 0; i--) 
		{
			reversing.Append(number[i]);
		}
		
		number = reversing.ToString();
		
		int numberX = 0;
		
		for (int i = 0; i < number.Length; i++) 
		{
			numberX += numberX + (int.Parse(number[i].ToString()) * (int)Math.Pow(baseX, i));
		}
		
		if (baseY == 10) 
		{
			Console.WriteLine(numberX);
		}
		else
		{
			List<string> endNumber = new List<string>();
			while (numberX > 0) 
			{
				int modulo = numberX % baseY;
				switch (modulo) 
				{
					case 10:
						endNumber.Add("A");
						break;
					case 11:
						endNumber.Add("B");
						break;
					case 12:
						endNumber.Add("C");
						break;
					case 13:
						endNumber.Add("D");
						break;
					case 14:
						endNumber.Add("E");
						break;
					case 15:
						endNumber.Add("F");
						break;
					default:
						endNumber.Add(modulo.ToString());
						break;
						
				}				
			numberX = numberX / baseY;
			}
		
			endNumber.Reverse();
			foreach (var item in endNumber) 
			{
				Console.Write(item);
			}
			Console.WriteLine();
		
		}
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}
