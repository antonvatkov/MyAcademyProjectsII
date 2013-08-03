using System;
class OneDayOfTheWeek
{
	public static void Main()
	{
		DayOfWeek today = DateTime.Today.DayOfWeek;
		Console.WriteLine("Today is {0}",today);
		
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}
