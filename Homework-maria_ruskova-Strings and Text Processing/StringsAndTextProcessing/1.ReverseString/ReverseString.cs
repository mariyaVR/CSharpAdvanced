using System;
using System.Linq;

class ReverseString
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string reversed = string.Join("", input.ToArray().Reverse());
        Console.WriteLine(reversed);
    }
}

