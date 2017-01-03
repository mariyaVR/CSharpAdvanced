using System;
using System.Collections.Generic;
using System.Linq;

class LongestIncreasingSequence
{
    static void Main()
    {
        int numberLongest = 0;
        int bestCount = 0;
        int longestCount = 0;
        
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        List<List<int>> sequences = new List<List<int>>();

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            var count = CountSequence(i, numbers);

            if (count >= bestCount)
            {
                bestCount = count;
                int number = i;
                i += count - 1;

                PrintSequence(number, bestCount, numbers);

                if (bestCount > longestCount)
                {
                    longestCount = bestCount;
                    numberLongest = number;
                }

                bestCount = 0;
            }
        }

        Console.Write("Longest: ");
        PrintSequence(numberLongest, longestCount, numbers);
    }

    private static void PrintSequence(int number, int bestCount, int[] array)
    {
        for (int l = number; l <= number + bestCount - 1; l++)
        {
            Console.Write("{0} ", array[l]);
        }
        Console.WriteLine();
    }

    private static int CountSequence(int i, int[] array)
    {
        int count = 1;
        int j = i + 1;
        int k = i;
        while (array[k] < array[j])
        {
            count++;
            j++;
            k++;
            if (j >= array.Length)
            {
                break;
            }
        }

        return count;
    }
}