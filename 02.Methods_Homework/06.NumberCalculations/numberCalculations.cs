using System;


    class numberCalculations
    {
        static void Main()
        {
            Console.WriteLine("Please enter numbers of type double:");
            string[] n = Console.ReadLine().Split();
            double[] doubles = new double[n.Length];
            
            for (int i = 0; i < n.Length; i++)
            {
                doubles[i] = double.Parse(n[i]);                
            }
            
            Console.WriteLine("Min: {0}, Max: {1}, Sum: {2}, Average: {3}, Product: {4}",
            GetMin(doubles), GetMax(doubles), GetSum(doubles), Average(doubles), GetProduct(doubles));

            //enter decimals
            Console.WriteLine("Please enter numbers of type decimal:");
            string[] dec = Console.ReadLine().Split();
            decimal[] decimals = new decimal[dec.Length];

            for (int i = 0; i < n.Length; i++)
            {
                decimals[i] = decimal.Parse(dec[i]);
            }
            Console.WriteLine("Min: {0}, Max: {1}, Sum: {2}, Average: {3}, Product: {4}",
            GetMin(decimals), GetMax(decimals), GetSum(decimals), Average(decimals), GetProduct(decimals));
        }

        // Calculate Min
        static double GetMin (double[]number)
        {
            double min = double.MaxValue;

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i]<min)
                {
                    min = number[i];
                }
            }
            return min;
        }
        static decimal GetMin(decimal[] number)
        {
            decimal min = decimal.MaxValue;

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] < min)
                {
                    min = number[i];
                }
            }
            return min;
        }
        // Calculate Max
        static double GetMax(double[] number)
        {
            double max = double.MinValue;

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] > max)
                {
                    max = number[i];
                }
            }
            return max;
        }
        static decimal GetMax(decimal[] number)
        {
            decimal max = decimal.MinValue;

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] > max)
                {
                    max = number[i];
                }
            }
            return max;
        }

        //Sum
        static double GetSum (double[]number)
        {
            double sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }
            return sum;
        }
        static decimal GetSum(decimal[] number)
        {
            decimal sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }
            return sum;
        }

        // Calculate average
        static double Average(double[]number)
        {
            double average = GetSum(number) / number.Length;
            return average;
        }
        static decimal Average(decimal[] number)
        {
            decimal average = GetSum(number) / number.Length;
            return average;
        }

        //Product
        static double GetProduct (double[] number)
        {
            double product = 1;
            for (int i = 0; i < number.Length; i++)
            {
                product *= number[i];
            }
            return product;
        }
        static decimal GetProduct(decimal[] number)
        {
            decimal product = 1;
            for (int i = 0; i < number.Length; i++)
            {
                product *= number[i];
            }
            return product;
        }
    }

