using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

    class wordCount
    {
        static void Main(string[]args)
        {
            StreamReader readWords = new StreamReader("../../words.txt");
            using (readWords)
            {
                StreamReader readText = new StreamReader("../../text.txt");
                using (readText)
                {
                    StreamWriter writeResult = new StreamWriter("../../result.txt");
                    using (writeResult)
                    {
                        string text = readText.ReadToEnd().ToLower();
                        var result  = new SortedDictionary<int, string>();
                        string word;

                        while ((word = readWords.ReadLine()) != null)
                        {
                            var pattern = string.Format(@"\b{0}\b", word.ToLower());
                            var match = Regex.Matches(text, pattern);
                            result.Add(match.Count, word);
                        }

                        foreach (var match in result.Reverse())
                        {
                            writeResult.WriteLine("{0} - {1}", match.Value, match.Key);
                        }
                    }
                }                
            }
        }
    }

