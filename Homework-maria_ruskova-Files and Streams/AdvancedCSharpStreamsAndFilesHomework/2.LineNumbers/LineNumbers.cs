using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LineNumbers
{
    static void Main(string[] args)
    {
        using (var reader = new StreamReader("../../LineNumbers.cs"))
        {
            using (var writer = new StreamWriter("../../GenFile.txt"))
            {
                int rowCounter = 1;
                var line = reader.ReadLine();
                while (line != null)
                {
                    writer.WriteLine("{0,2}. {1}", rowCounter, line);
                    rowCounter++;
                    line = reader.ReadLine();
                }
            }
        }

        Console.WriteLine("File done");
    }
}