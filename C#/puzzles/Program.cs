using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] newArr = RandomArray();
            // foreach (int item in newArr)
            // {
            //     System.Console.WriteLine(item);
            // }
            // MinMaxSum(newArr);
            // CoinToss();
            // TossMultipleCoins(20);;
            List<string> names = new List<string>()
            {
                "Todd",
                "Tiffany",
                "Charlie",
                "Geneva",
                "Sydney"
            };
            Names(names);
            Console.WriteLine("Hello World!");
        }
        public static int[] RandomArray()
        {
            int[] newArr = new int[10];
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                newArr[i] = rand.Next(5, 25);
            }

            return newArr;
        }
        public static void MinMaxSum(int[] numbers)
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
                };
            };
            System.Console.WriteLine($"The Max of the Random Array is {max}");
            System.Console.WriteLine($"The Min of the Random Array is {min}");
            System.Console.WriteLine($"The Sum of the Random Array is {sum}");
        }
        public static int CoinToss()
        {
            System.Console.WriteLine("Tossing a Coin!");
            Random rand = new Random();
            int toss = rand.Next(1, 3);
            if (toss == 1)
            {
                System.Console.WriteLine("Heads it is!");
                return toss;
            }
            else
            {
                System.Console.WriteLine("It's tails!");
                return toss;
            }
        }
        public static double TossMultipleCoins(int num)
        {
            int counter = 0;
            int i = 0;
            while (i < num)
            {
                CoinToss();
                if (CoinToss() == 1)
                {
                    counter++;
                }
                i++;
            }
            double result = (num / counter);
            System.Console.WriteLine(result);
            return result;
        }
        public static List<string> Names(List<string> names)
        {
            List<string> NameList = new List<string>();
            List<string> FinalNameList = new List<string>();
            Random rand = new Random();
            int i = 0;
            while (i < names.Count)
            {
                int random = rand.Next(0, names.Count);
                if (!NameList.Contains(names[random]))
                {
                    System.Console.WriteLine(names[random]);
                    NameList.Add(names[random]);
                    i++;
                }
            }
            foreach (string name in names)
            {
                if (name.Length > 5)
                {
                    FinalNameList.Add(name);
                }
            }
            foreach (string name in FinalNameList)
            {
                System.Console.WriteLine(name);
            }
            return FinalNameList;
        }
    };
}