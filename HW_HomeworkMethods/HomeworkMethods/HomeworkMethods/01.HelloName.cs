/*
 *Write a method that asks the user for his name and prints “Hello, <name>” 
 *(for example, “Hello, Peter!”). Write a program to test this method. 
*/
using System;
class helloName
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your name.");
        string yourName = Console.ReadLine();
        PrintName(yourName);
    }

     static void PrintName(string yourName)
    {
        string hello = "Hello";
        
         Console.WriteLine("{0}, {1}!", hello, yourName);
    }
}

