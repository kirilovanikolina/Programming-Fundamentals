using System;
using System.Numerics;	
public class Program
{
	public static void Main()
	{
		int n = int.Parse(Console.ReadLine());
        	Console.WriteLine(BigInteger.Pow(new BigInteger(n), n));
	}
}
