using System;
using System.Linq;

class LargerThanNeighbours
{
    static void Main(string[] args)
    {
        string[] chars = new string[] { ", " };
        int[] numbers = Console.ReadLine()
            .Split(chars, StringSplitOptions
            .RemoveEmptyEntries)
            .Select(int.Parse).ToArray();
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(IsLargerThanNeighbours(numbers, i));
        }
    }

    private static bool IsLargerThanNeighbours(int[] arr, int index)
    {
        if (index != 0 && index != arr.Length - 1)
        {
            if (arr[index] > arr[index + 1] && arr[index] > arr[index - 1])
            {
                return true;
            }
        }
        else if (index == 0 && arr[index] > arr[index + 1])
        {
            return true;
        }
        else if (index == arr.Length - 1 && arr[index] > arr[index - 1])
        {
            return true;
        }

        return false;
    }
}