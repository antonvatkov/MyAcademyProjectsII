/* Write a program that reads an integer number and 
 * calculates and prints its square root. If the number 
 * is invalid or negative, print "Invalid number". In all 
 * cases finally print "Good bye". Use try-catch-finally.
 */
using System;
class UsingTryCatchFinallyExption
{
	public class ParseSqrtException
	{
		public static void Main()
		{
			try 
			{
				int sqrt = int.Parse(Console.ReadLine());
				if (sqrt < 0) 
				{
					throw new FormatException();
				}
				Console.WriteLine(Math.Sqrt(sqrt));
			}
			catch (ArgumentNullException) 
			{
				Console.WriteLine("Please enter a positive argument which is not null.");
				Main();
			}
			catch (FormatException alert)
			{
				Console.WriteLine("Invalid number {0} . Please enter correct value -> some number.",alert.Message);
				Main();
			}
			catch	(OverflowException)
			{
				Console.WriteLine("Number is small or too big. Please enter a number in integer type of range.");
				Main();
			}
			finally
			{
				Console.WriteLine("Goodbye!");
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
