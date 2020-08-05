using System;
using System.Collections.Generic;

namespace memory
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] gameboard = new int[4, 4];
            string[,] showboard = new string[4, 4];
            List<string> myMatches = new List<string>();
            SetUpBoard(gameboard);
            ShowBoard(showboard);
            bool gamerunning = new bool();
            gamerunning = true;
            while (gamerunning == true)
            {
                System.Console.WriteLine("Please select the first number of your first card choice");
                // int x1 = Convert.ToInt32(System.Console.ReadLine());
                bool x1Val = false;
                int x1 = -1;
                string sx1 = System.Console.ReadLine();
                while (!x1Val)
                {
                    try
                    {
                        x1 = Convert.ToInt32(sx1);
                        x1Val = true;
                    }
                    catch (System.Exception)
                    {
                        System.Console.WriteLine("Invalid selection, please enter a number!");
                        sx1 = System.Console.ReadLine();
                        // throw;
                    }
                }

                System.Console.WriteLine("Please select the second number of your first card choice");
                // int y1 = Convert.ToInt32(System.Console.ReadLine());
                bool y1Val = false;
                int y1 = -1;
                string sy1 = System.Console.ReadLine();
                while (!y1Val)
                {
                    try
                    {
                        y1 = Convert.ToInt32(sy1);
                        y1Val = true;
                    }
                    catch (System.Exception)
                    {
                        System.Console.WriteLine("Invalid selection, please enter a number!");
                        sy1 = System.Console.ReadLine();
                        // throw;
                    }
                }
                System.Console.WriteLine("Please select the first number of your second card choice");
                // int x2 = Convert.ToInt32(System.Console.ReadLine());
                bool x2Val = false;
                int x2 = -1;
                string sx2 = System.Console.ReadLine();
                while (!x2Val)
                {
                    try
                    {
                        x2 = Convert.ToInt32(sx2);
                        x2Val = true;
                    }
                    catch (System.Exception)
                    {
                        System.Console.WriteLine("Invalid selection, please enter a number!");
                        sx2 = System.Console.ReadLine();
                        // throw;
                    }
                }
                System.Console.WriteLine("Please select the second number of your second card choice");
                // int y2 = Convert.ToInt32(System.Console.ReadLine());
                bool y2Val = false;
                int y2 = -1;
                string sy2 = System.Console.ReadLine();
                while (!y2Val)
                {
                    try
                    {
                        y2 = Convert.ToInt32(sx1);
                        y2Val = true;
                    }
                    catch (System.Exception)
                    {
                        System.Console.WriteLine("Invalid selection, please enter a number!");
                        sy2 = System.Console.ReadLine();
                        // throw;
                    }
                }
                if (Match(gameboard, x1, y1, x2, y2) == true)
                {
                    myMatches.Add($"[{x1},{y1}],[{x2},{y2}]");
                }
                //try later to make this the gameboard[x, y] and do x*y/2 for the ammount you need to win so you can resize board
                if (myMatches.Count == 8)
                {
                    gamerunning = false;
                    System.Console.WriteLine("Congrats! You found all matches!!! I take back everything I ever said about you, even the stuff you don't know about!! ^_^");
                }
                ShowBoard(showboard);
                System.Console.WriteLine($"Matching pairs found at");
                PrintMatchingPairs(myMatches);
            }
        }
        public static void SetBoardValues(int[,] matrix)
        {
            int num = 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = num;
                    if (j % 2 == 1)
                    {
                        num++;
                    }
                    // Console.Write(matrix[i, j] + "\t");
                }
                // Console.WriteLine();
            }
        }
        public static void Shuffle(int[,] array)
        {
            Random rand = new Random();
            int lengthRow = array.GetLength(1);

            for (int i = array.Length - 1; i > 0; i--)
            {
                int i0 = i / lengthRow;
                int i1 = i % lengthRow;

                int j = rand.Next(i + 1);
                int j0 = j / lengthRow;
                int j1 = j % lengthRow;

                int temp = array[i0, i1];
                array[i0, i1] = array[j0, j1];
                array[j0, j1] = temp;
            }
        }
        public static void SetUpBoard(int[,] matrix)
        {
            SetBoardValues(matrix);
            Shuffle(matrix);
            // for (int i = 0; i < matrix.GetLength(0); i++)
            // {
            //     for (int j = 0; j < matrix.GetLength(1); j++)
            //     {
            //         Console.Write(matrix[i, j] + "\t");
            //     }
            //     Console.WriteLine();
            // }
        }
        public static bool Match(int[,] gameboard, int x1, int y1, int x2, int y2)
        {
            if (gameboard[x1, y1] == gameboard[x2, y2])
            {

                System.Console.WriteLine("Hey! You found a match, updating matches found!!");
                return true;
            }
            else
            {
                System.Console.WriteLine($"Sorry no match, value at [{x1},{y1}] is {gameboard[x1, y1]} and value at [{x2},{y2}] is {gameboard[x2, y2]}");
                return false;
            }
        }
        public static void ShowBoard(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = $"[{i},{j}]";
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public static void PrintMatchingPairs(List<string> matches)
        {
            foreach (string item in matches)
            {
                System.Console.WriteLine(item);
            }
        }

    }
}