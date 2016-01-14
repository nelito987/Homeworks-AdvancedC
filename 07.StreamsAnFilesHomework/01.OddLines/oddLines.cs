﻿using System;
using System.IO;

    class oddLines
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("../../InOddLines.txt");
            using (reader)
            {                
                    int lineNumber = 0;
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        lineNumber++;
                        if (lineNumber % 2 ==1)
                        {
                           Console.WriteLine("{0} {1}", lineNumber, line);
                        }
                        line = reader.ReadLine();
                    }
                
            }
        }
    }

