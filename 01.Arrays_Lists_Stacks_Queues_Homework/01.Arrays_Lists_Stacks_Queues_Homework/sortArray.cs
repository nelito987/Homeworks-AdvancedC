using System;
using System.Collections.Generic;


class joinLists
{
    static void Main()
    {
        string[] arr = Console.ReadLine().Split();
        int[] number = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            number[i] = int.Parse(arr[i]);
        }

        for (int j = 0; j < number.Length; j++)
        {
            for (int i = 0; i < number.Length - 1; i++)
            {
                if (number[i] > number[i + 1])
                {
                    int temp = number[i + 1];
                    number[i + 1] = number[i];
                    number[i] = temp;
                }
            }
            
        }
        for (int i = 0; i < number.Length; i++)
        {
            Console.Write(number[i] + " ");
        }
        Console.WriteLine();
    }
}

