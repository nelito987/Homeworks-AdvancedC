using System;
using System.Collections.Generic;
using System.Linq;

    class terroristWin
    {
        static char[] input;                     
               
        static void SetBomb (int start, int end, int bomb)
        {
            int beginning = start - bomb;
            int endBomb = end + bomb;

            if (bomb == 0)
            {
                return;
            }
            if (beginning < 0)
            {
                beginning = 0;
            }
            else if (endBomb > (input.Length-1))
            {
                endBomb = input.Length - 1;
            }

            for (int i = beginning; i <= endBomb; i++)
            {
                input[i] = '.';
            }
        }

        static void Main()
        {
            input = Console.ReadLine().ToCharArray();            
            int bombStart;
            int bombEnd;              

            for (int i = 0; i < input.Length; i++)
            {
                int sum = 0;
                int capacity = 0;

                if (input[i] == '|')
                {
                    bombStart = i;
                    for (int a = i + 1; a < input.Length; a++)
                    {
                        if (input[a] == '|')
                        {
                            bombEnd = a;
                            i = a;
                            capacity = sum %10;
                            SetBomb(bombStart, bombEnd, capacity);
                            break;
                        }
                        sum += input[a];                      
                    }
                }
                
            }            

            foreach (var ch in input)
            {
                Console.Write(ch + "");
            }
            Console.WriteLine();
        }
    }

