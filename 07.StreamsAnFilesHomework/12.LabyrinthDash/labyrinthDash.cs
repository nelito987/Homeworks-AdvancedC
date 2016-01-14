using System;

class labyrinthDash
{
    static void Main(string[] args)
    {
        int numberOfRows = int.Parse(Console.ReadLine());
        char[][] labyrinth = new char[numberOfRows][];
        int lives = 3;
        int movesCount = 0;
        int row = 0;
        int col = 0;


        for (int i = 0; i < numberOfRows; i++)
        {
            labyrinth[i] = Console.ReadLine().ToCharArray();
        }

        string moves = Console.ReadLine();

        foreach (char move in moves)
        {
            int prevCol = col;
            int prevRow = row;

            if (move == '>')
            {
                col++;
            }
            else if (move == '<')
            {
                col--;
            }
            else if (move == '^')
            {
                row--;
            }
            else if (move == 'v')
            {
                row++;
            }

            if (col < 0 || row < 0 || col >= labyrinth[row].Length || row >= numberOfRows || labyrinth[row][col] == ' ')
            {
                movesCount++;
                Console.WriteLine("Fell off a cliff! Game Over!");
                break;
            }
            else if (labyrinth[row][col] == '|' | labyrinth[row][col] == '_')
            {
                Console.WriteLine("Bumped a wall.");
                row = prevRow;
                col = prevCol;
            }
            else if (labyrinth[row][col] == '@' | labyrinth[row][col] == '#' | labyrinth[row][col] == '*')
            {
                lives--;
                Console.WriteLine("Ouch! That hurt! Lives left: {0}", lives);
                movesCount++;
                if (lives <= 0)
                {
                    Console.WriteLine("No lives left! Game Over!");
                    break;
                }
            }
            else if (labyrinth[row][col] == '$')
            {
                lives++;
                Console.WriteLine("Awesome! Lives left: {0}", lives);
                labyrinth[row][col] = '.';
                movesCount++;
            }
            else if (labyrinth[row][col] == '.')
            {
                movesCount++;
                Console.WriteLine("Made a move!");
            }

        }
        Console.WriteLine("Total moves made: {0}", movesCount);
    }
}

