/* Write a program that enters file name along 
 * with its full file path (e.g. C:\WINDOWS\win.ini), 
 * reads its contents and prints it on the console. 
 * Find in MSDN how to use System.IO.File.ReadAllText(…). 
 * Be sure to catch all possible exceptions and print user-friendly
 * error messages.
 */
using System;
using System.IO;
class AllPossibleExeption
{
	public static void Main()
	{
		try
		{
			Console.WriteLine("Enter the files location.");
			string path = Console.ReadLine();
			string textContetn = File.ReadAllText(path);
		}
		catch	(DirectoryNotFoundException message)
		{
			Console.WriteLine(" {0}", message.Message);
		}
		catch	(FileNotFoundException message)
		{
			Console.WriteLine(" {0}", message.Message);
		}
		catch	(ArgumentNullException message)
		{
			Console.WriteLine(" {0}", message.Message);
		}
		catch	(ArgumentException message)
		{
			Console.WriteLine(" {0}", message.Message);
		}
		catch	(PathTooLongException message)
		{
			Console.WriteLine(" {0}", message.Message);
		}
		catch	(UnauthorizedAccessException message)
		{
			Console.WriteLine(" {0}", message.Message);
		}
		catch	(NotSupportedException message)
		{
			Console.WriteLine(" {0}", message.Message);
		}
		catch	(IOException message)
		{
			Console.WriteLine(" {0}", message.Message);
		}
		catch	(Exception message)
		{
			Console.WriteLine("{0} - {1}", message.GetType(), message.Message);
		}
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}
