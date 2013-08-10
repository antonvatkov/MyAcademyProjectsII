/* Write a method ReadNumber(int start, int end) that enters an integer 
 * number in given range [start…end]. If an invalid number or non-number
 * text is entered, the method should throw an exception. Using this method
 * write a program that enters 10 numbers:
 * a1, a2, … a10, such that 1 < a1 < … < a10 < 100
 */
using System;
class ThrowExeption
{

	public static int ReadNumber(int start, int end)
	{
		if (start > end)
		{
			throw new ArgumentException("Start value is bigger that end value!");
		}
		int firstNumber = int.Parse(Console.ReadLine());
		if (firstNumber > end || firstNumber < start) 
		{
			throw new ArgumentOutOfRangeException();
		}
		return firstNumber;
	}
	
	
	public static void Main()
	{
		int min = 1;
		int max = 100;
		try
		{
			for (int i = 0; i < 10; i++) 
			{
				Console.WriteLine("Enter a number in the range of [ {0} , {1} ] ",min, max);
				max = ReadNumber(min,max);
			}
		}
		catch ( FormatException formatMessage)
		{
			Console.WriteLine(formatMessage.Message);
		}
		catch(ArgumentOutOfRangeException outOfRange)
		{
			Console.WriteLine(outOfRange.Message);
		}
		catch (ArgumentException argExeption)
		{
			Console.WriteLine(argExeption.Message);
		}
		catch (Exception EverythingElse)
		{
			Console.WriteLine(" {0} -> {1}", EverythingElse.GetType(), EverythingElse.Message);
		}
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}