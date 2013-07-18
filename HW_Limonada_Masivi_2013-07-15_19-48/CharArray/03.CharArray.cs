/*
* Write a program that compares two char arrays lexicographically (letter by letter).
*/
using System;
class CharArray
{
	public static void Main()
	{
		//string is array of characters
		
		Console.WriteLine("Please enter test word");
		string testWord=Console.ReadLine();
		
		//allocates array of chars
		char [] word = new char[]{'a','a','a','a','a','a','a','a'};
		
		
		int position=0;
		int counterLength=Math.Min(testWord.Length,word.Length);
		
		for (int i = 0; i < counterLength; i++) 
		{
			position=i+1;
			if (testWord[i]==word[i])
			{
				Console.WriteLine("Match letters on position {0}->{1}",position,testWord[i]);
			}
			else
			{
				Console.WriteLine("Letters don`t match at position {0}",position);
			}
		}
		
		//system commands personal customization
		
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}
