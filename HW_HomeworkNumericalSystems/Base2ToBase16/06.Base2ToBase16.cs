using System;
using System.Collections.Generic;
using System.Text;

public class Base2ToBase16
{
    public static void Main()
    {
    	Console.WriteLine("Please enter binary number with length range of minimum 4 digits");
    	string bin = Console.ReadLine();
        StringBuilder reverser = new StringBuilder();
        for (int i = bin.Length - 1; i >= 0; i--)
        {
            reverser.Append(bin[i]);
        }

        bin = reverser.ToString();
        int numOfParts = (int)Math.Ceiling((double)bin.Length / 4);

        List<string> hex = new List<string>();

        for (int i = 0; i < numOfParts; i++)
        {
            int hexPart = 0;
            for (int j = 0; j < 4; j++)
            {
            	hexPart = hexPart + (int.Parse(bin[(4 * i) + j].ToString()) * ((int)Math.Pow(2, j)));
            }

            switch (hexPart)
            {
                case 10:
                    hex.Add("A");
                    break;
                case 11:
                    hex.Add("B");
                    break;
                case 12:
                    hex.Add("C");
                    break;
                case 13:
                    hex.Add("D");
                    break;
                case 14:
                    hex.Add("E");
                    break;
                case 15:
                    hex.Add("F");
                    break;
                default:
                    hex.Add(hexPart.ToString());
                    break;
            }
        }

        hex.Reverse();
        foreach (var item in hex)
        {
            Console.Write(item);
        }

        Console.WriteLine();
    	Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
    }
}
