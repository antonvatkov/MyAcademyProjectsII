using System;
using System.Collections.Generic;

public class Base16ToBase2
{
    public static void Main()
    {
    	Console.WriteLine("Please enter hexadecimal number.");
    	string hex = Console.ReadLine();
    	hex.ToUpper().ToString();
    	List<int> binNum = new List<int>();
        for (int i = hex.Length - 1; i >= 0; i--)
        {
            int hexPart = 0;
            List<int> binPart = new List<int>();
            switch (hex[i])
            {
                case 'A':
                    hexPart = 10;
                    break;
                case 'B':
                    hexPart = 11;
                    break;
                case 'C':
                    hexPart = 12;
                    break;
                case 'D':
                    hexPart = 13;
                    break;
                case 'E':
                    hexPart = 14;
                    break;
                case 'F':
                    hexPart = 15;
                    break;
                default:
                    hexPart = Convert.ToInt32(hex[i]);
                    break;
            }

            for (int j = 0; j < 4; j++)
            {
                binPart.Add(hexPart % 2);
                hexPart = hexPart / 2;
            }

            binNum.AddRange(binPart);
        }

        binNum.Reverse();
        foreach (var item in binNum)
        {
            Console.Write(item);
        }

        Console.WriteLine();
    	Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
    }
}
