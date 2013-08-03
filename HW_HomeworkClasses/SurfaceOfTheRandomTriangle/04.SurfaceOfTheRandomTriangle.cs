
using System;


	class triangleSurface
	{
		public static double GetAngle(double sideA,double sideB,double sideC)
		{
			double surface=GetSurface(sideA,sideB,sideC);
			double angle=(2*surface)/(sideA*sideB);
			return angle;
		}
		public static double GetHeight(double sideA,double sideB,double sideC)
		{
			
			double height=(2*GetArea(sideA,sideB,sideC))/sideA;
			return height;
		}
		public static double GetArea(double sideA,double sideB,double sideC)
		{
			double area=(sideA+sideB+sideC);
			return area;
		}
		public static double GetHupotenuse(double sideA,double sideB)
		{
			double hipotenuse=Math.Sqrt((sideA*sideA)+(sideB*sideB));
			return hipotenuse;
		}
		public static double GetSurface(double sideA,double sideB,double sideC)
		{
			double areaSmall=(GetArea(sideA,sideB,sideC))/2;
			double surface=Math.Sqrt(areaSmall*((areaSmall-sideA)*(areaSmall-sideB)*(areaSmall-sideC)));
			return surface;
		}
		public static void Main()
		{
			Console.WriteLine("Enter the first side.");
			double sideA= double.Parse(Console.ReadLine());
			Console.WriteLine("Enter the second side.");
			double sideB=double.Parse(Console.ReadLine());
			double sideC=GetHupotenuse(sideA,sideB);
			Console.WriteLine("The triangle hipotenuse is:{0}",Math.Round(sideC,2));
			Console.WriteLine("The triangle surface is:{0}",Math.Round(GetSurface(sideA,sideB,sideC)));
			Console.WriteLine("The triangle height is:{0}",Math.Round(GetHeight(sideA,sideB,sideC),2));
			double angle=Math.Round(GetAngle(sideA,sideB,sideC),2);
			Console.WriteLine("The triangle angle is:{0}",Math.Sin(angle) + "in rad");
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}