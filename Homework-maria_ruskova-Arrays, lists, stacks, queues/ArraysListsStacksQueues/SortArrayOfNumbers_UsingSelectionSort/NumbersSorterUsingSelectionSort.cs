using System;
using System.Collections.Generic;
using System.Linq;

class NumbersSorterUsingSelectionSort
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        SelectionSort(numbers);

        string sortedNumbers = string.Join(" ", numbers);
        Console.WriteLine(sortedNumbers);
    }

    private static void SelectionSort(int[] array)
    {       
        for (int i = 0; i < array.Length; i++)
        {
            int min = array[i];
            int position = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < min)
                {
                    min = array[j];
                    position = j;
                }
            }

            int oldVlaue = array[i];
            array[i] = min;
            array[position] = oldVlaue;
        }
    }
}
