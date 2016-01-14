using System;
using System.Collections.Generic;
using System.Linq;

    class fillTheMatrix
    {
        static int size = 0;        

        static void Main()
        {
            size = int.Parse(Console.ReadLine());
            MatrixA();
            Console.WriteLine();
            MatrixB();            
        }

        static void MatrixA()
        {
            int[,] matrix = new int[size, size];
            int counter = 1;
            for (int cols = 0; cols < size; cols++)
            {
                for (int rows = 0; rows < size; rows++)
                {
                    matrix[rows, cols] = counter;
                    counter++;
                }
            }
            PrintMatrix(matrix);
        }

        static void MatrixB()
        {
            int[,] matrix = new int[size, size];
            int counter = 1;
            for (int cols = 0; cols < size; cols++)
            {
               if (cols % 2 == 0)
               {
                   for (int rows = 0; rows < size; rows++)
                   {
                       matrix[rows, cols] = counter;
                       counter++;
                   }
               }
               else
               {
                   for (int rows = size-1; rows >= 0; rows--)
                   {
                       matrix[rows, cols] = counter;
                       counter++;
                   }
               }
            }
            PrintMatrix(matrix);
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    Console.Write("{0,2} ", matrix[rows,cols]);
                }
                Console.WriteLine();
            }
        }
    }

