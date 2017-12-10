using System;		
public class Program
{
	public static void Main()
	{
		int n = int.Parse(Console.ReadLine());
        	if(n < 16) Console.WriteLine(double.Parse(Console.ReadLine()));
        	else if(n < 29) Console.WriteLine(decimal.Parse(Console.ReadLine()));
	}
}
