using System;
class Array10000Digits
{
    public static void NumberSetting(int[] arrayAlfa,int[] arrayBeta)
    {
        int length = 0;
        if (arrayAlfa.Length > arrayBeta.Length)
        {
            length = arrayAlfa.Length + 1;
        }
        else
        {
            length = arrayBeta.Length + 1;
        }

        int[] arraySum = new int[length];

        for (int i = 0; i < arraySum.Length; i++)
        {
            if (i < arrayAlfa.Length)
            {
                arraySum[i] += arrayAlfa[i];
                if (arraySum[i] >= 10)
                {
                    arraySum[i] -= 10;
                    arraySum[i + 1] += 1;
                }
            }
            if (i < arrayBeta.Length)
            {
                arraySum[i] += arrayBeta[i];
                if (arraySum[i] >= 10)
                {
                    arraySum[i] -= 10;
                    arraySum[i + 1] += 1;
                }
            }
        }

        Array.Reverse(arraySum);

        for (int i = 0; i < arraySum.Length; i++)
        {
            Console.Write(arraySum[i]);
        }
        Console.WriteLine();
    }
    
    public static void Main()
    {
        int[] arrayAlfa = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] arrayBeta = new int[9] { 11, 12, 13, 14, 15, 16, 17, 18, 19 };
        NumberSetting(arrayAlfa, arrayBeta);
        Console.ReadKey(true);
    }
}

