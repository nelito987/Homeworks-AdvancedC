using System;
using System.Collections.Generic;
using System.Linq;

    class collectTheCoins
    {
        static int coinsCount = 0;
        static int wallsCount = 0;
        static int currentRow = 0;
        static int currentCol = 0;        
        
        static char [][] jaggedArray = new char[4][];
        static char [] moves;
        static char currentChar;

        static void Main()
        {                        
            for (int i = 0; i < jaggedArray.Length; i++)
			{
                char[] elements = Console.ReadLine().ToCharArray();
                jaggedArray[i] = elements;
			}
            moves = Console.ReadLine().ToCharArray();

            CountWallsAndCoins(moves);

            Console.WriteLine("Walls hit {0}", wallsCount);
            Console.WriteLine("Coins collected {0}", coinsCount);
        }

        static int CountWallsAndCoins(char[]moves)
        {
            

            for (int i = 0; i < moves.Length; i++)
            {
                if (moves[i] == 'V' && currentRow < jaggedArray.GetLength(0) && currentCol < jaggedArray[currentRow + 1].Length)
                {
                    currentRow++;
                    CountCoins();
                    continue;
                }
                else if (moves[i] == 'V' && currentCol >= jaggedArray[currentRow+1].Length)
                {
                    wallsCount++;
                    CountCoins();
                    continue;
                }
                else if (moves[i] == '^' && currentRow == 0)
                {
                    wallsCount++;
                    CountCoins();
                    continue;
                }
                else if (moves[i] == '^' && currentRow > 0)
                {
                    currentRow--;
                    CountCoins();
                    continue;
                }
                else if (moves[i] == '>' && currentCol == jaggedArray[currentRow].Length)
                {
                    wallsCount++;
                    CountCoins();
                    continue;
                }
                else if (moves[i] == '>' && currentCol < jaggedArray[currentRow].Length)
                {
                    currentCol++;
                    CountCoins();
                    continue;
                }
                else if (moves[i] == '<' && currentCol == 0)
                {
                    wallsCount++;
                    CountCoins();
                    continue;
                }
                else if (moves[i] == '<' && currentCol > 0)
                {
                    currentCol--;
                    CountCoins();
                    continue;
                }
            }
            return wallsCount;
        }

        static void CountCoins()
        {             
            currentChar = jaggedArray[currentRow][currentCol];
            if (currentChar == '$')
            {
                coinsCount++;
            }           
       }

    }

