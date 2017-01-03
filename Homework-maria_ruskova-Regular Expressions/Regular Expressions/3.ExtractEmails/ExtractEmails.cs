using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ExtractEmails
{
    static void Main(string[] args)
    {
        string pattern = 
            @"(?<=\s|^)([^\W_][\w.-]*[^\W_]|[^\W_])@[^\W_](([a-zA-Z-]*[a-zA-Z]+|[a-zA-Z]*)\.([a-zA-Z]+[a-zA-Z-]*|[a-zA-Z]*))+[^\W_]\b";
        string input = Console.ReadLine();
        Regex reg = new Regex(pattern, RegexOptions.Multiline);
        Match m = reg.Match(input);
        while (m.Success)
        {
            Console.WriteLine(m);
            m = m.NextMatch();
        }
    }
}

