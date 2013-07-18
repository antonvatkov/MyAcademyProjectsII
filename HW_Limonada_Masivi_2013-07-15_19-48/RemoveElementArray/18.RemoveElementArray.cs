/*
*Write a program that reads an array of integers and removes from it a minimal number of elements in such way that the remaining array is sorted in increasing order. Print the remaining sorted array. Example:
*{6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}
*/
using System;
using System.Collections.Generic;
class RemoveElementArray
{
	 public static bool AreSorted(List<long> array)
    {
        bool isSorted = true;
        for (int i = 0; i < array.Count - 1; i++)
        {
            if (!(array[i] <= array[i + 1]))
            {
                isSorted = false;
            }
        }

        return isSorted;
    }

    public static void Main()
    {

        long[] elements = { 7, 5, 4, 6, 5, 3, 6, 6, 6 };

        int len = 0;
        int bestLen = 0;
        List<long> bestResult = new List<long>();
        int maxSubsets = (int)Math.Pow(2, elements.Length);
        for (int i = 1; i < maxSubsets; i++)
        {
            List<long> result = new List<long>();

            for (int j = 0; j <= elements.Length; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;
                if (bit == 1)
                {
                    result.Add(elements[j]);
                    len++;
                }
            }

            if (AreSorted(result))
            {
                if (len > bestLen)
                {
                    bestLen = len;
                    bestResult = result;
                }
            }

            len = 0;
        }

        foreach (var item in bestResult)
        {
            Console.Write("{0} ", item);
        }
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}
