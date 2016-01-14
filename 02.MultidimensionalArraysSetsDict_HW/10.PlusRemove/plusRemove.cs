using System;
using System.Collections.Generic;

    class plusRemove
    {
        static void Main()
        {            
            List<List<char>> board = new List<List<char>>();
        

            string text = Console.ReadLine();
            for (int row = 0; text != "END"; row++)
            {
                board.Add(new List<char>(text.Length));
                for (int col = 0; col < text.Length; col++)
                {
                    board[row].Add(text[col]);
                }
                text = Console.ReadLine();
            }

            char currentValue = '\0';
            HashSet<KeyValuePair<int, int>> coordinatesSet = new HashSet<KeyValuePair<int, int>>();
            for (int row = 1; row < board.Count - 1; row++)
            {
                for (int col = 1; col < board[row].Count - 1; col++)
                {
                    currentValue = Char.ToLower(board[row][col]);
                    if (col <board[row-1].Count && currentValue.Equals(Char.ToLower(board[row-1][col])) 
                        && currentValue.Equals(Char.ToLower(board[row][col-1])) && currentValue.Equals(Char.ToLower(board[row][col+1]))
                        && col < board[row+1].Count && currentValue.Equals(Char.ToLower(board[row+1][col])))
                    {
                        coordinatesSet.Add(new KeyValuePair<int, int>(row, col));
                        coordinatesSet.Add(new KeyValuePair<int, int>(row - 1, col));
                        coordinatesSet.Add(new KeyValuePair<int, int>(row + 1, col));
                        coordinatesSet.Add(new KeyValuePair<int, int>(row, col + 1));
                        coordinatesSet.Add(new KeyValuePair<int, int>(row, col - 1));
                    }
                }
            }

            for (int row = 0; row < board.Count; row++)
            {
                for (int col = 0; col < board[row].Count; col++)
                {
                    KeyValuePair<int, int> currentPair = new KeyValuePair<int,int>(row, col);
                    if (!coordinatesSet.Contains(currentPair))
                    {
                        Console.Write(board[row][col]);
                    }                    
                }
                Console.WriteLine();
            }
        }
    }

