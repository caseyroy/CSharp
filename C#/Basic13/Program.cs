using System;
using System.Collections.Generic;

namespace Basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            // PrintNumbers();
            // PrintOdds();
            // PrintSum();
            int[] loopTestArray = { 1, 2, 3, 4, 5 };
            int[] findMaxArray = { 24, 6, 99, 5000, 128, 250 };
            int[] eliminateNegativesArray = { 1, -2, 4, 6, -7, 9, -10 };
            int[] maxMinAvgArray = { 3, 6, 9, 15, 24, 1, 34 };

            OddArray();
            // System.Console.WriteLine(OddArray());
            // LoopArray(loopTestArray);
            // System.Console.WriteLine(FindMax(findMaxArray));
            // GetAverage(loopTestArray);
            // SquareArrayValues(loopTestArray);
            // System.Console.WriteLine(GreaterThanY(loopTestArray, 2));
            // EliminateNegatives(eliminateNegativesArray);
            // MinMaxAverage(maxMinAvgArray);
            // ShiftValues(loopTestArray);
            // object[] NumToStringResults = NumToString(eliminateNegativesArray);

            Console.WriteLine("Hello World!");
        }
        public static void PrintNumbers()
        {
            int i = 1;
            while (i <= 255)
            {
                System.Console.WriteLine(i);
                i++;
            }

        }
        public static void PrintOdds()
        {
            for (int i = 1; i <= 255; i++)
            {
                if (i % 2 != 0)
                {
                    System.Console.WriteLine(i);
                }
            }
        }
        public static void PrintSum()
        {
            int sum = 0;
            for (int i = 1; i <= 255; i++)
            {
                sum += i;
                System.Console.WriteLine(i);
                System.Console.WriteLine(sum);
            }
        }
        public static void LoopArray(int[] numbers)
        {
            foreach (int num in numbers)
            {
                System.Console.WriteLine(num);
            }
        }
        public static int FindMax(int[] numbers)
        {
            int max = numbers[0];
            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }
        public static void GetAverage(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            int avg = sum / numbers.Length;
            System.Console.WriteLine(avg);
        }
        public static List<int> OddArray()
        {
            List<int> newArr = new List<int>();
            for (int i = 1; i <= 255; i++)
            {
                if (i % 2 != 0)
                {
                    newArr.Add(i);
                }
            }
            foreach (int item in newArr)
            {
                System.Console.WriteLine(item);
            }
            return newArr;
        }
        public static int GreaterThanY(int[] numbers, int y)
        {
            int counter = 0;
            foreach (int num in numbers)
            {
                if (y < num)
                {
                    counter++;
                }
            }
            return counter;
        }
        public static void SquareArrayValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= numbers[i];
            }
            //printing an array in c#
            Array.ForEach(numbers, System.Console.WriteLine);
        }
        public static void EliminateNegatives(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
            }
            Array.ForEach(numbers, System.Console.WriteLine);
        }
        public static void MinMaxAverage(int[] numbers)
        {
            int max = numbers[0];
            int min = numbers[0];
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
                if (num > max)
                {
                    max = num;
                }
                else if (num < min)
                {
                    min = num;
                }
            }
            int avg = sum / numbers.Length;
            System.Console.WriteLine($"Max is {max}");
            System.Console.WriteLine($"Min is {min}");
            System.Console.WriteLine($"Average is {avg}");
        }
        public static void ShiftValues(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                numbers[i - 1] = numbers[i];
            }
            numbers[numbers.Length - 1] = 0;
            Array.ForEach(numbers, System.Console.WriteLine);

        }
        public static object[] NumToString(int[] numbers)
        {
            object[] newArr = new object[numbers.Length];
            numbers.CopyTo(newArr, 0);
            for (int i = 0; i < newArr.Length; i++)
            {
                if ((int)newArr[i] < 0)
                {
                    newArr[i] = "Dojo";
                }
            }
            //loop runs when function is called so you dont have to do it outside of the function to see the results
            foreach (object item in newArr)
            {
                System.Console.WriteLine(item);
            }
            return newArr;
        }
    }
}
