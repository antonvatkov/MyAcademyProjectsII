/* Write a program to convert decimal 
 * numbers to their binary representation.
 */
using System;
using System.Text;
class BinaryCoverter
{
	public static void Main()
	{
		Console.WriteLine("Please enter an number.");
		int decNumber = int.Parse(Console.ReadLine());
		StringBuilder hexNumber = new StringBuilder();
		
		while (decNumber > 0) 
		{
			switch (decNumber % 16) 
			{
				case 10:
					hexNumber.Append('A');
					break;
				case 11:
					hexNumber.Append('B');
					break;
				case 12:
					hexNumber.Append('C');
					break;
				case 13:
					hexNumber.Append('D');
					break;
				case 14:
					hexNumber.Append('E');
					break;
				case 15:
					hexNumber.Append('F');
					break;
				default:
					hexNumber.Append(decNumber % 16);
					break;
			}	
		decNumber /= 16;
		}
		
		
		string result = hexNumber.ToString();
		
		for (int i = result.Length -1 ; i > -1; i--) 
		{
			Console.Write(result[i]);
		}
		
		Console.WriteLine();
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}
