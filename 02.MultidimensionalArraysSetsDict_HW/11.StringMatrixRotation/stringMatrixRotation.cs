using System;
using System.Collections.Generic;
using System.Linq;

    class stringMatrixRotation    {                
        
        static void Main()
        {
            List<string> board = new List<string>();
            string [] command = Console.ReadLine().Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);           
            string input = Console.ReadLine();            
            int MaxLength = 0;

            while (input != "END")
            {
                int currentLength = input.Length;
                if (currentLength > MaxLength)
                {
                    MaxLength = currentLength;
                }

                board.Add(input);
                input = Console.ReadLine();
            }

            for (int i = 0; i < board.Count; i++)
            {
                board[i] = board[i].PadRight(MaxLength, ' ');
            }

            int degrees = int.Parse(command[1]);

            switch (degrees % 360)
            {
                case 0: ZeroRotation(board, MaxLength); break;
                case 90: Rotate90(board, MaxLength); break;
                case 180: Rotate180(board, MaxLength); break;
                case 270: Rotate270(board, MaxLength); break;
            }
           
        }

        static void Rotate90(List<string> board, int maxLength)
        {
            for (int col = 0; col < maxLength; col++)
            {
                for (int row = board.Count-1; row >= 0; row--)
                {
                    Console.Write(board[row][col]);
                }
                Console.WriteLine();
            }
        }

        static void Rotate180(List<string> board, int maxLength)
        {
            for (int row = board.Count-1; row >= 0; row--)
            {
                for (int col = maxLength-1; col >= 0; col--)
			    {
                    Console.Write(board[row][col]);
			    }
                Console.WriteLine();
            }
        }

        static void Rotate270(List<string> board, int maxLength)
        {
            for (int col = maxLength - 1; col >= 0; col--)
            {
                for (int row = 0; row < board.Count; row++)
                {
                    Console.Write(board[row][col]);
                }
                Console.WriteLine();
            }
        }

        static void ZeroRotation(List<string> board, int maxLength)
        {
            for (int row = 0; row < board.Count; row++)
            {
                for (int col = 0; col < maxLength; col++)
                {
                    Console.Write(board[row][col]);
                }
                Console.WriteLine();
            }
        }
    }

