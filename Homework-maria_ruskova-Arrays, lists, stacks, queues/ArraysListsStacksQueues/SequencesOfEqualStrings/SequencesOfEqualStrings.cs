using System;
using System.Collections.Generic;
using System.Linq;

class SequencesOfEqualStrings
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ').ToArray();

        Console.Write("{0} ", input[0]);
        for (int i = 1; i < input.Length; i++)
        {
            if (input[i - 1] == input[i])
            {
                Console.Write("{0} ", input[i]);
            }
            else
            {
                Console.Write("\n{0} ", input[i]);
            }
        }

        Console.WriteLine();
    }
}
