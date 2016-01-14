using System;

    class largerThanNeighbours
    {
        static void Main()
        {
            int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(IsLargerThanNeighbours(numbers,i));
            }
        }

        static bool IsLargerThanNeighbours (int[] numbers, int i)
        {
            bool result = false;

            if (i == 0)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    result = true;
                }               
            }
            else if (i == numbers.Length - 1)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    result = true;
                }                
            }
            else
            {
                if (numbers[i] > numbers[i + 1] && numbers[i] > numbers[i - 1])
                {
                    result = true;
                }                
            }

            return result;
        }
    }

