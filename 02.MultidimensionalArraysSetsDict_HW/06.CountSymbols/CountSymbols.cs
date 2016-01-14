using System;
using System.Collections.Generic;
using System.Linq;

    class CountSymbols
    {
        static void Main()
        {
            string text = Console.ReadLine();
            IDictionary<char, int> symbolCount = new SortedDictionary<char, int>();

            foreach (char symbol in text)
            {
              if (symbolCount.ContainsKey(symbol))
              {
                  symbolCount[symbol]++;
              }
              else
              {
                  symbolCount.Add(symbol, 1);
              }
            }

            foreach (KeyValuePair<char, int> pair in symbolCount)
            {
                Console.WriteLine("{0}: {1} time/s", pair.Key, pair.Value);
            }
        }
    }

