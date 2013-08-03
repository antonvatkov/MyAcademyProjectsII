/* Write a method that calculates the number of workdays between 
 * today and given date, passed as parameter. Consider that workdays
 * are all days from Monday to Friday except a fixed 
 * list of public holidays specified preliminary as array.
 */
using System;
class WorkdayCountdown
{
	public static void Main()
	{
		Console.WriteLine("Please enter year/mount/day.");
		string[] dataString = Console.ReadLine().Split('/');
		int day = int.Parse(dataString[2]);
		int mounth = int.Parse(dataString[1]);
		int year = int.Parse(dataString[0]);
		
		DateTime startDay = DateTime.Today;
		DateTime closeDay = new DateTime(year,mounth,day);
		int range = 0;
		range = Math.Abs((closeDay - startDay).Days);
		
		if (startDay > closeDay) 
		{
			startDay = closeDay;
			closeDay = DateTime.Today;			
		}
		
		DateTime[] holidays = 
		{
			new DateTime(2014,1,1),
			new DateTime(2013,2,2),
			new DateTime(2013,3,3),
			new DateTime(2013,4,4),
			new DateTime(2014,1,18)
		};
		
		Console.WriteLine(range);
		int counter = 0;
		bool holiday = false;
		
		for (int i = 0; i < range; i++) 
		{
			startDay = startDay.AddDays(1);
			if ((startDay.DayOfWeek != DayOfWeek.Sunday) && (startDay.DayOfWeek != DayOfWeek.Saturday)) 
			{
				for (int v = 0; v < holidays.Length; v++) 
				{
					if (startDay == holidays[v]) 
					{
						holiday = true;
						break;
					}	
				}
				
				if (!holiday) 
				{
					counter++;	
				}				
				
				holiday = false;
				
			}
		}
		
		Console.WriteLine(counter);
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}