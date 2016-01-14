using System;
using System.Linq;
using System.Text;

    class palindromes
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split(new char[] { ',', ':', ';', ' ', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);            

            for (int i = 0; i < words.Count(); i++)
            {
                var reversed = new string(words[i].ToCharArray().Reverse().ToArray());                

                if(words[i] == reversed)
                {
                    Console.WriteLine(string.Join(", ", words[i]));
                }
            }

        }
    }

