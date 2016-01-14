using System;
using System.Linq;
using System.Text;

    class textFilter
    {
        static void Main()
        {
            string [] banned = Console.ReadLine().Split(new char [] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder text = new StringBuilder(Console.ReadLine());            
            string[] bannedAsteriks = new string[banned.Count()];

            for (int i = 0; i < banned.Count(); i++)
            {
                bannedAsteriks[i] = new string('*', banned[i].Length);
                text.Replace(banned[i], bannedAsteriks[i]);
            }
            Console.WriteLine(text);
        }
    }

