using System;
using System.Collections.Generic;

    class nightLife
    {
        static void Main()
        {
            Dictionary<string, SortedDictionary<string, SortedSet<string>>> nightLife = new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();

            string[] input = Console.ReadLine().Split(';');
            
            string city = String.Empty;
            string venue = String.Empty;
            string performer = String.Empty;

            do
            {
                city = input[0];
                venue = input[1];
                performer = input[2];

                if (!nightLife.ContainsKey(city))
                {
                    nightLife[city] = new SortedDictionary<string, SortedSet<string>>();
                }
                if (!nightLife[city].ContainsKey(venue))
                {
                    nightLife[city][venue] = new SortedSet<string>();
                }
                nightLife[city][venue].Add(performer);
                input = Console.ReadLine().Split(';');
            } while (input[0] != "END");

            foreach (var cityPair in nightLife)
            {
                Console.WriteLine(cityPair.Key);
                foreach (var venuePair in cityPair.Value)
                {
                    Console.WriteLine("->{0}:{1}",venuePair.Key, String.Join(", ", venuePair.Value));
                }
            }
        }
    }

