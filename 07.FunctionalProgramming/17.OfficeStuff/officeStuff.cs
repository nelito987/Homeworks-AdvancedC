using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class officeStuff
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            SortedDictionary<string, Dictionary<string, int>> companies = new SortedDictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] order = Console.ReadLine().Split(new char[] { '|', '-', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (!(companies.ContainsKey(order[0])))
                {
                    companies.Add(order[0], new Dictionary<string, int>());
                    companies[order[0]].Add(order[2], int.Parse(order[1]));
                }
                else if (!(companies[order[0]].ContainsKey(order[2])))
                {
                    companies[order[0]].Add(order[2], int.Parse(order[1]));
                }
                else
                {
                    companies[order[0]][order[2]] += int.Parse(order[1]);
                }
            }

            foreach (var company in companies)
            {
                var printInfo = company.Value.Select(x => String.Format("{0}-{1}", x.Key, x.Value));
                Console.WriteLine("{0}: {1}", company.Key, string.Join(", ", printInfo));
            }
        }
    }

