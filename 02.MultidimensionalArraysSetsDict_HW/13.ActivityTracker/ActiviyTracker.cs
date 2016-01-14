using System;
using System.Collections.Generic;

class ActivityTracker
{    
       static void Main()
    {
        SortedDictionary<int, SortedDictionary<string, int>> data = new SortedDictionary<int, SortedDictionary<string, int>>();
        
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string [] input = Console.ReadLine().Split(new char [] {' ', '/'}, StringSplitOptions.RemoveEmptyEntries);
            int month = int.Parse(input[1]);
            string runnerName = input[3];
            int meters = int.Parse(input[4]);

            if(!data.ContainsKey(month))
            {
                data[month] = new SortedDictionary<string, int>();
            }
            if (!data[month].ContainsKey(runnerName))
            {
                data[month][runnerName] = meters;
            }
            else
            {
                data[month][runnerName] += meters;
            }
        }

        foreach (var m in data.Keys)
        {
            Console.Write(m + ":");
            int count = 0;
            SortedDictionary<string, int> spyData = data[m];
            foreach (var runner in spyData)
            {
                Console.Write(" {0}({1})", runner.Key, runner.Value);
                count++;
                if (count < spyData.Count)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine();
        }
    }    
}

