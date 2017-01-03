using System;
using System.Collections.Generic;
using System.Linq;

class FirstLargerThanNeighbours
{
    static void Main(string[] args)
    {
        string[] chars = new string[] { ", " };
        int[] sequenceOne = Console.ReadLine()
            .Split(chars, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();
        int[] sequenceTwo = Console.ReadLine()
            .Split(chars, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();
        int[] sequenceThree = Console.ReadLine()
            .Split(chars, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();

        Console.WriteLine(GetIndexOfFirstLarger(sequenceOne));
        Console.WriteLine(GetIndexOfFirstLarger(sequenceTwo));
        Console.WriteLine(GetIndexOfFirstLarger(sequenceThree));
    }

    private static int GetIndexOfFirstLarger(int[] arr)
    {
        for (int index = 0; index < arr.Length; index++)
        {
            if (index != 0 && index != arr.Length - 1)
            {
                if (arr[index] > arr[index + 1] && arr[index] > arr[index - 1])
                {
                    return index;
                }
            }
            else if (index == 0 && arr[index] > arr[index + 1])
            {
                return index;
            }
            else if (index == arr.Length - 1 && arr[index] > arr[index - 1])
            {
                return index;
            }
        }

        return -1;
    }
}