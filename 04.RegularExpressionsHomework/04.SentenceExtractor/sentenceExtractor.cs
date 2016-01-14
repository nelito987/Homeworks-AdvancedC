using System;
using System.Text.RegularExpressions;

    class sentenceExtractor
    {
        static void Main()
        {
            string keyword = Console.ReadLine();
            string text = Console.ReadLine();
            string pattern = string.Format(@".*?\b{0}\b.*?[^!.?][!.?]", keyword);
            
            MatchCollection sentences = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);

            foreach (Match sentence in sentences)
            {
                Console.WriteLine(sentence.Groups[0]);
            }
        }
    }

