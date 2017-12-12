using System;	
using System.Linq;
public class Program
{
	public static void Main()
	{
		    var stringArray = Console.ReadLine().Split().ToArray();
        var array = new int[stringArray.Length];
        for (int i = 0; i < array.Length; i++)
            array[i] = int.Parse(stringArray[i]);
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 1 && Math.Abs(array[i] % 2) == 1)
                Console.WriteLine($"Index {i} -> {array[i]}");
        }
	}
}
