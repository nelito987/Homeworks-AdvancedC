using System;
using System.Text.RegularExpressions;


    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string pattern = @"[a-z0-9]+([_.-][a-z0-9]+)*@[a-z]+\-*[a-z]*(\.+[a-z]+)+";
            Regex rgx = new Regex(pattern);
            MatchCollection emails = rgx.Matches(text);

            foreach (Match email in emails)
            {
                Console.WriteLine(email.Groups[0]);
            }
        }
    }

