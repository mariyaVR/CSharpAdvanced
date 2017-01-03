using System;
using System.Collections.Generic;
using System.Linq;

class UnicodeCharacters
{
    static void Main(string[] args)
    {
        var chars = Console.ReadLine().ToList();
        chars.ForEach(x =>
        {
            Console.Write("u\\" + ((int)x).ToString("X4"));
        });

        Console.WriteLine();
    }
}