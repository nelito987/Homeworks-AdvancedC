using System;
using System.IO;

    class lineNumbers
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("../../InOddLines.txt");
            using (reader)
            {
                StreamWriter writer = new StreamWriter("../../OutOddLines.txt");
                using (writer)
                {
                    int lineNumber = 0;
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        lineNumber++;
                        writer.WriteLine("{0,3} {1}", lineNumber, line);
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }

