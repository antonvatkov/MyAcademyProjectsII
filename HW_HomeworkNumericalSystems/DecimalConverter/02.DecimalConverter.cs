using System;
class DecimalConverter
{
	public static void Main()
	{
		Console.WriteLine("Please enter an number.");
		string number = Console.ReadLine();
		int numberDecimal = 0;
		
		for (int i = 0; i < number.Length; i++) 
		{
			numberDecimal = numberDecimal << 1;	
			if (number[i] == '1') 
			{
				numberDecimal = numberDecimal ^ 1;	
			}
		
		}
		
		Console.WriteLine(numberDecimal);
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}
