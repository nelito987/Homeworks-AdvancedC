using System;

    class lastDigitOfNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
                        
            Console.WriteLine(GetLastDigitAsWord(n));
        }

        static string GetLastDigitAsWord(int n)
        {
            int lastDigit = n % 10;
            string output = " ";

            switch(lastDigit)
            {
                case 1: output = "one"; break;
                case 2: output = "two"; break;
                case 3: output = "three"; break;
                case 4: output = "four"; break;
                case 5: output = "five"; break;
                case 6: output = "six"; break;
                case 7: output = "seven"; break;
                case 8: output = "eight"; break;
                case 9: output = "nine"; break;
                default: output = "zero"; break;
            }

            return output;
        }
    }

