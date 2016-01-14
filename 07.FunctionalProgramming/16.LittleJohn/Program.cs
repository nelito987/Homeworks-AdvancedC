using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

    class Program
    {
        static void Main()
        {    
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                sb.AppendFormat(" {0}", Console.ReadLine());
            }
            string arrowPattern = @"(>>>----->>)|(>>----->)|(>----->)";
            Regex matchArrows = new Regex(arrowPattern);
            var arrows = matchArrows.Matches(sb.ToString());

            int largeCount = 0;
            int medCount = 0;
            int smallCount = 0;

            foreach (Match match in arrows)
            {
                if(!string.IsNullOrEmpty(match.Groups[1].Value))
                {
                    largeCount++;
                }
                if (!string.IsNullOrEmpty(match.Groups[2].Value))
                {
                    medCount++;
                }
                else if(!string.IsNullOrEmpty(match.Groups[3].Value))
                {
                    smallCount++;
                }
            }
                        
            string numberAsString = smallCount.ToString() + medCount.ToString() + largeCount.ToString();
            //Console.WriteLine(number);
            int number = int.Parse(numberAsString);
            string numberToBin = Convert.ToString(number, 2);
            //Console.WriteLine(numberToBin);
            string reversed = new string(numberToBin.Reverse().ToArray());
            string finalBin = numberToBin + reversed;
            int final = Convert.ToInt32(finalBin, 2);
            Console.WriteLine(final);
        }
    }

