using System;

    class firstLargerThanNeigbours
    {
        static void Main()
        {
            int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
            int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
            int[] sequenceThree = { 1, 1,1 };

            Console.WriteLine(GetIndexOfFirstelementLargerThanNeighbours(sequenceOne));
            Console.WriteLine(GetIndexOfFirstelementLargerThanNeighbours(sequenceTwo));
            Console.WriteLine(GetIndexOfFirstelementLargerThanNeighbours(sequenceThree));
        }

        static int GetIndexOfFirstelementLargerThanNeighbours (int[] seq)
        {
            for (int i = 0; i < seq.Length; i++)
            {
                if(IsLargerThanNeighbours(seq, i))
                {
                    return i;
                }
            }
                return -1;
        }

        static bool IsLargerThanNeighbours(int[] numbers, int i)
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

