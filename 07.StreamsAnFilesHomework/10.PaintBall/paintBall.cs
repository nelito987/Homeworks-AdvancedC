using System;
using System.Linq;

    class paintBall
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int[] canvas = new int[10];

            for (int row = 0; row < 10; row++)
            {
                canvas[row] = 1023;
            }
            int counter = 0;
            int sum = 0;

            while (input != "End")
            {
                int[] data = input.Split().Select(int.Parse).ToArray();
                int rowPaint = data[0];
                int colPaint = data[1];
                int radius = data[2];

                int startRow = Math.Max(rowPaint - radius,0);
                int endRow = Math.Min(rowPaint + radius, 9);
                int startCol = Math.Max(colPaint - radius, 0);
                int endCol = Math.Min(colPaint + radius, 9);

                int maskSize = endCol - startCol +1;
                int mask = (1 << maskSize) - 1;

                for (int i = startRow; i <= endRow; i++)
                {
                    if (counter % 2 == 1)
                    {
                        canvas[i] |= (mask << startCol);
                    }
                    else
                    {
                        canvas[i] &=  ~(mask << startCol);
                    }
                }
                counter++; 
                input = Console.ReadLine();              
            }

            for (int i = 0; i < 10; i++)
            {
                sum += canvas[i];
            }
            Console.WriteLine(sum);
   
        }
    }

