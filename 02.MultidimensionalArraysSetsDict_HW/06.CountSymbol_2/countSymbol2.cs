using System;
using System.Collections.Generic;
using System.Linq;

    class countSymbol2
    {
        static void Main()
        {
            string text = Console.ReadLine();
            IDictionary<char, int> symbolCount = new SortedDictionary<char, int>();

            foreach (char symbol in text)
            {
                int count;
                if (!symbolCount.TryGetValue(symbol, out count))
                {
                    count = 0;
                }
                symbolCount[symbol] = count + 1;
            }

            foreach (KeyValuePair<char, int> pair in symbolCount)
            {
                Console.WriteLine("{0}: {1} time/s", pair.Key, pair.Value);
            }
        }
    }

