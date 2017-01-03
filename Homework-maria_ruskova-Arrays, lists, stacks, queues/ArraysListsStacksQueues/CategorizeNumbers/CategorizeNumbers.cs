using System;
using System.Collections.Generic;
using System.Linq;

class CategorizeNumbers
{
    static void Main(string[] args)
    {
        double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        List<double> floatNumbers = new List<double>();
        List<int> roundNumbers = new List<int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            double floatNum = numbers[i];
            int roundNum = (int)floatNum;

            if (floatNum == roundNum)
            {
                roundNumbers.Add(roundNum);
            }
            else
            {
                floatNumbers.Add(floatNum);
            }
        }

        string floats = string.Join(" ", floatNumbers);
        string rounds = string.Join(" ", roundNumbers);

        Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}\n",
            floats, floatNumbers.Min(), floatNumbers.Max(), floatNumbers.Sum(), floatNumbers.Average());
        Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}",
            rounds, roundNumbers.Min(), roundNumbers.Max(), roundNumbers.Sum(), (double)roundNumbers.Average());
    }
}