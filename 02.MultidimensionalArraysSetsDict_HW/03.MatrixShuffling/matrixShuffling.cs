using System;
using System.Collections.Generic;
using System.Linq;

    class matrixShuffling
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            string[,] matrix = new string[rows, cols];
            string temp = string.Empty;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = Console.ReadLine();
                }
            }            

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] commands = command.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                if (commands[0] == "swap" && commands.Length==5)
                {
                    int x1 = int.Parse(commands[1]);
                    int y1 = int.Parse(commands[2]);
                    int x2 = int.Parse(commands[3]);
                    int y2 = int.Parse(commands[4]);

                    if (x1 >= 0 && x1 < rows && x2 >= 0 && x2 < rows && y1 >= 0 && y1 < cols && y2 >= 0 && y2 < cols)
                    {
                        temp = matrix[x1, y1];
                        matrix[x1, y1] = matrix[x2, y2];
                        matrix[x2, y2] = temp;

                        Console.WriteLine("after swapping:");
                        for (int row = 0; row < rows; row++)
                        {
                            for (int col = 0; col < cols; col++)
                            {
                                Console.Write("{0,2}", matrix[row, col]);
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                command = Console.ReadLine();
            }   
        }       
    }

