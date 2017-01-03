﻿using System;
using System.Collections.Generic;
using System.Linq;

class SubSetSums
{
    static int[] numbers;
    static int N;
    static bool solution = false;

    static void Main()
    {
        N = int.Parse(Console.ReadLine());
        numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        List<int> subset = new List<int>();

        MakeSubset(0, subset);

        if (!solution)
        {
            Console.WriteLine("No matching subsets.");
        }
    }   

    private static void PrintSubset(List<int> subset)
    {
        Console.WriteLine("{0} = {1}", string.Join(" + ", subset), N);
    }

    static void MakeSubset(int index, List<int> subset)
    {
        int sum = subset.Sum();
        if (sum == N)
        {
            PrintSubset(subset);
            solution = true;
        }

        if (subset.Count == numbers.Length)
            return;

        for (int i = index; i < numbers.Length; i++)
        {
            subset.Add(numbers[i]);

            MakeSubset(i + 1, subset);
            subset.RemoveAt(subset.Count - 1);
        }
    }    
}
