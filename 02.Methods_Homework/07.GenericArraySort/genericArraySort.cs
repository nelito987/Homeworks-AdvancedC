using System;
using System.Collections.Generic;
using System.Linq;

    class genericArraySort
    {
        static void Main()
        {
            Console.WriteLine("Enter integers on one line, separated bu space:");
            int[] numArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine("Enter some strings on one line, separated bu space:");
            string[] stringArr = Console.ReadLine().Split(' ').ToArray();

            Console.WriteLine("Enter dates on a single line, separated bu space:");
            DateTime []  datesArr = Console.ReadLine().Split(' ').Select(DateTime.Parse).ToArray();

            Console.WriteLine(SortArray(numArr));
            Console.WriteLine(SortArray(stringArr));
            Console.WriteLine(SortArray(datesArr));

        }


        static string SortArray<T>(IEnumerable<T> arr)
        {
            List<T> temp = arr.ToList();
            List<T> sorted = new List<T>();

            while (temp.Count > 0)
            {
                var x = temp.Min();
                sorted.Add(x);
                temp.Remove(x);
            }

            return String.Join(", ", sorted);
        }
    }

