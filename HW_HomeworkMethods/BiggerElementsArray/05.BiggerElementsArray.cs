/*
 * Write a method that checks if the 
 * element at given position 
 * in given array of integers is bigger 
 * than its two neighbors (when such exist).
 */
using System;
class BiggerElementsArray
{
	public static bool BiggerInteger (int[] array, int position)
	{
        if ((position == 0) && (array.Length == 1))
        {
            return false;
        }
        else if ((position == 0) && (array.Length > 1))
        {
            if (array[position] > array[position +1])
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        else if ((position + 1 == array.Length) && (array.Length > 1))
        {
            if (array[position] > array[position - 1])
	        {
		        return true;
	        }
            else
            {
                return false;
            }
        }
        else if ((array[position] > array[position + 1]) && (array[position] > array[position -1]))
	    {
		    return true;
	    }
        else
        {
            return false;
        }
    }
	
    public static void Main ()
	{
		Console.WriteLine("Please enter a integer for position.");
		int position = int.Parse(Console.ReadLine());
		int[] array = new int[]{1,2,3,4,5,6,7,8};
        Console.WriteLine("The element on position {0} is bigger then its neighbors: {1}", position, BiggerInteger(array, position));
        Console.ReadKey(true);
    }
}