using System;
using System.Security;

namespace _14.TextGravity
{
    class textGravity
    {
        static void Main(string[] args)
        {
            int lineLenght = int.Parse(Console.ReadLine());
            char[] input = Console.ReadLine().ToCharArray();

            int cols = lineLenght;
            int rows = (int)Math.Ceiling((double)input.Length / lineLenght);
            //Console.WriteLine(row);
            string[,] matrix = new string[rows, cols];
            int index = 0;
            //Fill the matrix
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (index < input.Length)
                    {
                        matrix[row, col] = input[index].ToString();
                        index++;                        
                    }
                    else
                    {
                        matrix[row, col] = " ";
                    }                    
                }
            }
            //Falling
            bool fall = false;
            do
            {
                fall = false;
                for (int r = 0; r < rows - 1; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        if (matrix[r + 1, c] == " " && matrix[r, c] != " ")
                        {
                            matrix[r + 1, c] = matrix[r, c];
                            matrix[r, c] = " ";
                            fall = true;
                        }
                    }

                }
            } while (fall);

            //Print
            Console.Write("<table>");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("<tr>");
                for (int c = 0; c < cols; c++)
                {
                    Console.Write("<td>{0}</td>", SecurityElement.Escape(matrix[i,c]));
                }
                Console.Write("</tr>");
            }
            Console.Write("</table>");
        }
    }
}
