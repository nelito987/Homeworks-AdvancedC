using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


    class useYourChainsBuddy
    {
        static void Main()
        {
            string input = Console.ReadLine();
            //string patternPInput = @"(?:<\s*p\s*>)(.*?(?=<))(?:<\s*/p\s*>)";
            string patternPInput = @"<\s*p\s*>(.*?[^<])<\s*/p\s*>";
            StringBuilder sb = new StringBuilder();
            MatchCollection matches = Regex.Matches(input, patternPInput, RegexOptions.IgnoreCase);

            foreach (Match match in matches)
            {
                string text = Regex.Replace(match.Groups[1].Value, @"[^a-z0-9]+", " ");
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] >= 97 && text[i] <= 109)
                    {
                        sb.Append((char)(text[i] + 13));                            
                    }
                    else if (text[i] >=110 && text[i] <= 122)
                    {
                        sb.Append((char)(text[i]-13));
                    }
                    else
                    {
                        sb.Append(text[i]);
                    }
                   
                }
            }
            input = sb.ToString();
            string spaces = @"\s+";
            input  = Regex.Replace(input, spaces, " ");
            Console.WriteLine(input);
        }
    }

