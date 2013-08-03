using System;
class RandomVariables
{
	public static void Main()
	{
		Random generateRandom = new Random();
		
		for (int i = 0; i < 10; i++) 
		{
			Console.WriteLine(generateRandom.Next(100,201));
		}
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}
