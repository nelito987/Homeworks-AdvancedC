using System;
using System.Collections.Generic;
using System.Linq;


    class reverseString
    {
        static void Main()
        {
            Console.WriteLine("Enter some text:");
            string input = Console.ReadLine();
            string reversed = new string(input.Reverse().ToArray());
            Console.WriteLine(reversed);
        }
    }

