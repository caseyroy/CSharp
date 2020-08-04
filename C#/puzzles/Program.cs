using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomArray
            Console.WriteLine("Hello World!");
        }
        public static int[] RandomArray(int[] numbers)
        {
            int[] newArr = new int[10];
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                newArr[i] = rand.Next(5, 25);
            }
            Array.ForEach(newArr, System.Console.WriteLine);
        }
    }
}
