using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class TextFilter
{
    static void Main(string[] args)
    {
        var bans = Console.ReadLine();
        var banList = Regex.Split(bans, ", ").ToList();
        string text = Console.ReadLine();
 
        banList.ForEach(x =>
        {
            text = text.Replace(x, new string('*', x.Length));
        });

        Console.WriteLine(text);
    }
}