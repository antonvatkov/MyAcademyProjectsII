/*
 * Write a class Matrix, to holds a matrix of integers.
 * Overload the operators for adding, subtracting and
 * multiplying of matrices, indexer for accessing the matrix
 * content and ToString().
 * 
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
public class Matrix
{
	public int Row;
	public int Coll;
	static int[,] array;
	
	//constructor for the class Matrix
	
	public Matrix(int myRow, int myColl)
	{
		array = new int[myRow,myColl];
		Row = myRow;
		Coll = myColl;
	}
	public int this[int myRow, int myColl]
	{
		get
		{
			return array[myRow,myColl];
		}
		set
		{
			array[myRow,myColl] = value;
		}
	}

	public static Matrix subtraction (Matrix firstMatrix,Matrix secondMatrix)
	{
		Matrix resultMatrix = new Matrix(firstMatrix.Row,firstMatrix.Coll);
		for (int i = 0; i < firstMatrix.Row; i++) 
		{
			for (int v = 0; v < firstMatrix.Coll; v++) 
			{
				resultMatrix[i,v] = firstMatrix[i,v] + secondMatrix[i,v];
			}
		}
	return resultMatrix;
	}

	public override string ToString()
	{
		 string endString = null;
		 for (int i = 0; i < this.Row; i++) 
		 {
		 	for (int v = 0; v < this.Coll; v++) 
		 	{
		 		endString = endString + this[i,v] + " ";
		 	}	
		 endString = endString + "\n";
		 }
	return endString;
	}
}
	
class OverloadArrayToString
{
	public static void Main()
	{
		Matrix firstMatrix = new Matrix(3,3);
		Matrix secondMatrix = new Matrix(3,3);
		Random randomGen = new Random();
		for (int i = 0; i < firstMatrix.Row; i++) 
		{
			for (int v = 0; v < firstMatrix.Coll; v++) 
			{
				firstMatrix[i,v] = randomGen.Next(10);
				secondMatrix[i,v] = randomGen.Next(10);
			}	
		}
		
		Console.WriteLine("First matrix:");
		Console.WriteLine(firstMatrix);
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}






