using System;	
using System.Linq;
public class Program
{
	public static void Main()
	{
        	var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
		var element = int.Parse(Console.ReadLine());
        	var containsElement = false;
        	for (int i = 0; i < arr.Length; i++)
            		if (arr[i] == element)
            		{
                		containsElement = true; break;
            		}
        	if (containsElement)
            		Console.WriteLine("yes");
        	else
            		Console.WriteLine("no");
	}
}
