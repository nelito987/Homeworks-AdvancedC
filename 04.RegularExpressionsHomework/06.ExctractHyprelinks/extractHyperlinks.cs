using System;
using System.Text.RegularExpressions;


    class extractHyperlinks
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string text = string.Empty;

            while (input != "END")
            {
                text += input;
                input = Console.ReadLine();    
            }
            string pattern =  @"<\s*a\s+[^>]*?\bhref\s*=\s*(?:'(?<url>[^']*)'|""(?<url>[^""]*)""|(?<url>[^\s>]+))[^>]*>";           

            Regex links = new Regex(pattern);
            MatchCollection matches = links.Matches(text);

            foreach (Match link in matches)
            {
                Console.WriteLine(link.Groups["url"]);
            }
        }
    }

