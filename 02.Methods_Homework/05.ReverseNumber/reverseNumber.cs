using System;
using System.Linq;

    class reverseNumber
    {
        static void Main()
        {
            string n = Console.ReadLine();
            Console.WriteLine(GetReversedNumber(n));
        }

        static double GetReversedNumber(string n)
        {
            string reversed = string.Join("", n.ToString().Reverse());
            double number = double.Parse(reversed);
            return number;
        }
    }

