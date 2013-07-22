/*
 * Write a method that return the maximal element in a portion of array
 */
using System;
class MaxElementReturnArray
{
    public static int BiggerNeiborGet(int[] array)
    {
        
        int currentBigest = 0;
        int bigest = 0;
        for (int i = 1; i < array.Length - 1 ; i++)
        {
            if ((array[i] > array[i + 1]) && (array[i] > array[i - 1]))
            {
                currentBigest = array[i];
                if (bigest < currentBigest)
                {
                    bigest = currentBigest;
                }
            }
        }
        return bigest;
    }
    
    public static void Main ()
	{
        int[] array = new int[9] {1,2,3,4,5,6,7,8,9};
        Console.WriteLine(BiggerNeiborGet(array));
        Console.ReadKey(true);
    }
}