using System;
class CheckLeapYear
{
	public static void Main()
	{
		Console.WriteLine("Please enter the year,mount and the day.");
		string date = Console.ReadLine();
		DateTime today = DateTime.Parse(date);
		if (today.Year % 4 == 0) 
		{
			Console.WriteLine("The year is leap.");
		}
		else
		{
			Console.WriteLine("The year is not leap");
		}
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}
