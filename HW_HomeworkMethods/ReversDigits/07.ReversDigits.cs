using System;
using System.Text;
class ReversDigits
{
    public static string DigitReverse(string digit)
    {
        StringBuilder reversDigit = new StringBuilder();
        for (int i = digit.Length - 1 ; i >= 0;i --)
        {
            reversDigit.Append(digit[i]);
        }
        return reversDigit.ToString();
    }
    public static void Main ()
	{
        Console.WriteLine("Please insert a number.");
        string digit = Console.ReadLine();
        Console.WriteLine(DigitReverse(digit));
        Console.ReadKey(true);
	}
}

