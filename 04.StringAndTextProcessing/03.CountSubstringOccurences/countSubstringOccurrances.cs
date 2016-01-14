using System;
using System.Collections.Generic;
using System.Linq;

    class countSubstringOccurrances
    {
        static void Main()
        {
            string input = Console.ReadLine().ToLower();
            string keyword = Console.ReadLine().ToLower();
            int index = input.IndexOf(keyword);
            int count = 0;

            while (index != -1)
            {
                count++;
                index = input.IndexOf(keyword, index + 1);
            }
            Console.WriteLine(count);
        }
    }

