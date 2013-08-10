/* Write a program that downloads a file from Internet
 * (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores 
 * it the current directory. Find in Google how to download 
 * files in C#. Be sure to catch all exceptions and to free 
 * any used resources in the finally block.
 */
using System;
using System.Net;
class StoreFilesCatchExeption
{
	public static void Main()
	{
		WebClient download = new WebClient();
		using (download) 
		{
			try
			{
				download.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg",
				                      @"c:\Users\PC\Documents\test\test.jpg");
			}
			catch (ArgumentException message)
			{
				Console.WriteLine("{0} - {1}", message.GetType(), message.Message);
			}
			catch (WebException message)
			{
				Console.WriteLine("{0} - {1}", message.GetType(), message.Message);
			}
			catch (NotSupportedException message)
			{
				Console.WriteLine("{0} - {1}", message.GetType(), message.Message);
			}
			catch (Exception message)
			{
				Console.WriteLine("{0} - {1}", message.GetType(), message.Message);
			}
		}
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}
