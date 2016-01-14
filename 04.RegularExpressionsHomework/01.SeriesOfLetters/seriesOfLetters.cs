using System;
using System.Text.RegularExpressions;


    class seriesOfLetters
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"(\w)\1+";     // \w - всички  "alphanumeric characters" 
            string replacement = "$1";       // текста намерен в първата група на регулярния израз, в случая "\w"
            string result = Regex.Replace(input, pattern, replacement);
            Console.WriteLine(result);
            
         }
    }

