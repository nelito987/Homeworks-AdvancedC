using System;
using System.Collections.Generic;
using System.Linq;

    class toTheStars
    {
        static void Main()
        {
            string[] firstStar = Console.ReadLine().Split();
            string[] secondStar = Console.ReadLine().Split();
            string[] thirdStar = Console.ReadLine().Split();
            string[] NormandyCoordinates = Console.ReadLine().Split();
            int turns = int.Parse(Console.ReadLine());

            string firstStarName = firstStar[0].ToLower();
            double firstStarX = double.Parse(firstStar[1]);
            double firstStarY = double.Parse(firstStar[2]);

            string secondStarName = secondStar[0].ToLower();
            double secondStarX = double.Parse(secondStar[1]);
            double secondStarY = double.Parse(secondStar[2]);

            string thirdStarName = thirdStar[0].ToLower();
            double thirdStarX = double.Parse(thirdStar[1]);
            double thirdStarY = double.Parse(thirdStar[2]);

            double NormandyX = double.Parse(NormandyCoordinates[0]);
            double NormandyY = double.Parse(NormandyCoordinates[1]);

            for (double i = NormandyY; i <= (NormandyY+turns); i++)
            {
                if (InStar(NormandyX, i, firstStarX, firstStarY))
                {
                    Console.WriteLine(firstStarName);
                }
                else if (InStar(NormandyX, i, secondStarX, secondStarY))
                {
                    Console.WriteLine(secondStarName);
                }
                else if (InStar(NormandyX, i,thirdStarX, thirdStarY))
                {
                    Console.WriteLine(thirdStarName);
                }
                else
                {
                    Console.WriteLine("space");
                }
            }
                        
        }

        static bool InStar(double x, double y, double starX, double starY)
        {
            bool inStar = (x >= (starX - 1)) && (x <= (starX + 1)) && (y >= (starY - 1) && (y <= (starY + 1)));
            return inStar;
        }
      
    }

