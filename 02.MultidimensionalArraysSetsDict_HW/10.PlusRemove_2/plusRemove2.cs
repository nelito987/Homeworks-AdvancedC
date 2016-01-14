using System;
using System.Collections.Generic;

    class plusRemove2
    {
        static void Main()
        {
            List<string> startData = new List<string>();
            List<string> finalData = new List<string>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                startData.Add(input);
                finalData.Add(input);
                input = Console.ReadLine();
            }

            for (int i = 0; i < startData.Count-2; i++)
            {
                string firstLine = startData[i];
                string secondLine = startData[i + 1];
                string thirdLine = startData[i + 2];
                int length1 = firstLine.Length;
                int length2 = secondLine.Length;
                int length3 = thirdLine.Length;                

                for (int j = 1; j < Math.Min(Math.Min(length1, length2), length3) && j < length2 - 1; j++)
                {
                    string first = firstLine.Substring(j, 1).ToLower();
                    string second = secondLine.Substring(j - 1, 3).ToLower();
                    string third = thirdLine.Substring(j, 1).ToLower();
                    string match = new string(first[0], 3);

                    if (first == third && second == match)
                    {
                        finalData[i] = finalData[i].Remove(j, 1).Insert(j, "K");
                        finalData[i + 1] = finalData[i + 1].Remove(j - 1, 3).Insert(j-1,new string('K',3));
                        finalData[i + 2] = finalData[i + 2].Remove(j, 1).Insert(j, "K");
                    }
                }
            }

            for (int i = 0; i < finalData.Count; i++)
            {
                finalData[i] = finalData[i].Replace("K", "");
                Console.WriteLine(finalData[i]);
            }

        }
    }

