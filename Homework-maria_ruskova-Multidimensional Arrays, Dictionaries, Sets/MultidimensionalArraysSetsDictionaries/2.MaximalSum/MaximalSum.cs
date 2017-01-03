using System;
using System.Collections.Generic;
using System.Linq;

class MaximalSum
{
    static void Main(string[] args)
    {
        //input
        int[] dementions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        var matrix = new List<List<int>>();

        //fill matrix
        for (int i = 0; i < dementions[0]; i++)
        {
            matrix.Add(Console.ReadLine().Split(' ').Select(int.Parse).ToList());
        }

        //find biggest sum;
        int maxSum = int.MinValue;
        int[] position = new int[2];
        for (int i = 0; i < dementions[0] - 2; i++)
        {
            int currSum = 0;
            for (int j = 0; j < dementions[1] - 2; j++)
            {
                currSum =
                    matrix[i][j] + matrix[i][j + 1] + matrix[i][j + 2] +
                    matrix[i + 1][j] + matrix[i + 1][j + 1] + matrix[i + 1][j + 2] +
                    matrix[i + 2][j] + matrix[i + 2][j + 1] + matrix[i + 2][j + 2];

                if (currSum > maxSum)
                {
                    maxSum = currSum;
                    position[0] = i;
                    position[1] = j;
                }
            }
        }

        //print sum
        Console.WriteLine("Sum = {0}", maxSum);
        for (int i = position[0]; i < position[0] + 3; i++)
        {
            for (int j = position[1]; j < position[1] + 3; j++)
            {
                Console.Write("{0} ", matrix[i][j]);
            }

            Console.WriteLine();
        }
    }
}