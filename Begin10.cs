using System;
					
public class Program
{
	public static void Main()
	{
		double a = Math.Pow(Convert.ToDouble(Console.ReadLine()), 2);
		double b = Math.Pow(Convert.ToDouble(Console.ReadLine()), 2);
		Console.WriteLine(a + b + "\t" + (a - b) + "\t" + a * b + "\t" + a / b);
	}
}
