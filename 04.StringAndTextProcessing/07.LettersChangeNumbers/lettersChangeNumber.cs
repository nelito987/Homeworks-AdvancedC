using System;
using System.Linq;
using System.Text;

    class lettersChangeNumber
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
            decimal currentNum = 0;
            decimal sum = 0;

            for (int i = 0; i < input.Count(); i++)
            {
                string first = input[i].Substring(0, 1);
                char firstChar = first[0];
                string last = input[i].Substring(input[i].Length - 1, 1);
                char lastChar = last[0]; 
                decimal number = decimal.Parse(input[i].Substring(1, input[i].Length - 2));
                
                if(char.IsUpper(firstChar))
                {
                    currentNum = number / (firstChar - 64);
                }
                else
                {
                    currentNum = number * (firstChar - 96);
                }

                if (char.IsUpper(lastChar))
                {
                    currentNum -= lastChar - 64;
                }
                else
                {
                    currentNum += lastChar  - 96;
                }
                sum += currentNum;
            }
            Console.WriteLine("{0:F2}",sum);
        }
    }
