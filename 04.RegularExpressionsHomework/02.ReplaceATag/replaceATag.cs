using System;
using System.Text.RegularExpressions;

    class replaceATag
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"<\s*a\s+href=\s*([^>]+)>([^<]+)<\s*/a\s*>";
            Regex regex = new Regex(pattern);
            string replacement = "[URL href=$1]$2[/URL]";
            Console.WriteLine(regex.Replace(input, replacement));
        }
    }

