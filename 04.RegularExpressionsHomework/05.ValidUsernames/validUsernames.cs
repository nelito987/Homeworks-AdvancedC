using System;
using System.Text.RegularExpressions;
    class validUsernames
    {
        static void Main()
        {
            string usernames = Console.ReadLine();   //Split(new char[] { ' ', '/', '\\', '(', ')' });
            string pattern = @"\b[a-zA-Z]\w{2,24}\b";
            Regex users = new Regex(pattern);
            MatchCollection matches = users.Matches(usernames);
            int bestSum = int.MinValue;
            int sum = 0;
            int first = 0;
            int second = 0;

            for (int i = 0; i < matches.Count-1; i++)
            {
                sum = matches[i].Length + matches[i + 1].Length;
                if (sum > bestSum)
                {
                    bestSum = sum;
                    first = i;
                    second = i + 1;
                }
            }
            Console.WriteLine(matches[first]);
            Console.WriteLine(matches[second]);
        }
    }

