using System;
using System.Collections.Generic;


    class couplesFrequency
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries);
            
            Dictionary<string, int> data= new Dictionary <string, int>();            

            for (int i = 0; i < numbers.Length-1; i++)
            {
                string sequence = numbers[i] + " " + numbers[i + 1];
                if(!data.ContainsKey(sequence))
                {
                    data.Add(sequence, 1);
                }
                else
                {
                    data[sequence]++;
                }
            }
            foreach (KeyValuePair<string, int> item in data)
            {
                double percentage = (double)item.Value*100 / (numbers.Length - 1);
                Console.WriteLine("{0} -> {1:F2}%", item.Key, percentage);
            }
        }
    }

