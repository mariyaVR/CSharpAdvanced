using System;
using System.Collections.Generic;
using System.Linq;

class NumbersSorted
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
 
        Array.Sort(numbers);

        string sortedNumbers = string.Join(" ", numbers);
        Console.WriteLine(sortedNumbers);
    }
}
