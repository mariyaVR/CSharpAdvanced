using System;
using System.Collections.Generic;
using System.Linq;

class ReverseNumber
{
    static void Main(string[] args)
    {
        double input = double.Parse(Console.ReadLine());
        double reversed = GetReversedNumber(input);
        Console.WriteLine(reversed);
    }

    private static double GetReversedNumber(double num)
    {
        string number = num.ToString();
        string revursedNumber = string.Join("", number.Reverse());
        return double.Parse(revursedNumber);
    }
}