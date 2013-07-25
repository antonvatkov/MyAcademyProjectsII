/*
 * Write a method that counts how many times given number appears in given array. 
 * Write a test program to check if the method is working correctly.
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class CountElementAndCheck
{
	public static int NumberCounter(int[] array, int numForSearch)
    {
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == numForSearch)
            {
                counter++;
            }
        }

        return counter;
    }

    public static void Main()
    {
        int[] myArray = { 1, 2, 3, 4, 4, 4, 4, 4, 4, 5 };
        Console.WriteLine(" The number is appering {0} times", NumberCounter(myArray, 4));
        Console.ReadKey(true);
    }
}

