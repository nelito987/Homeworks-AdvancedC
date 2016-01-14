using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int radius = int.Parse(Console.ReadLine());
            int diskCenterRow = n / 2,  
                diskCenterCol = n / 2;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    int inDiskY = row - diskCenterRow;
                    int inDiskX = col - diskCenterCol;
                    double distance = Math.Sqrt((Math.Pow(inDiskX, 2) + Math.Pow(inDiskY, 2)));
                    bool inDisk = distance <= radius;

                    if(inDisk == true)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
        }
    }

