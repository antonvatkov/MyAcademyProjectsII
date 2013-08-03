/* Write a program to convert decimal 
 * numbers to their binary representation.
 */
using System;
class DecimalConvertion
{
	public static void Main()
	{
		Console.WriteLine("Please enter an number.");
		string inputNumber = Console.ReadLine();
		
		int outputNumber = 0;
		
		for (int i = inputNumber.Length - 1; i > - 1; i--) 
		{
			int power = inputNumber.Length - (i + 1);
			switch (inputNumber[i]) 
			{
				case 'A':
					outputNumber += (10 * (int)Math.Pow(16,power));
					break;
				case 'B':
					outputNumber += (11 * (int)Math.Pow(16,power));
					break;
				case 'C':
					outputNumber += (12 * (int)Math.Pow(16,power));
					break;
				case 'D':
					outputNumber += (13 * (int)Math.Pow(16,power));
					break;
				case 'E':
					outputNumber += (14 * (int)Math.Pow(16,power));
					break;
				case 'F':
					outputNumber += (15 * (int)Math.Pow(16,power));
					break;
				default:
					outputNumber = outputNumber + (int.Parse(inputNumber[i].ToString()) * (int)Math.Pow(16,power));
					break;
			}
		}
		Console.WriteLine(outputNumber);
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}
