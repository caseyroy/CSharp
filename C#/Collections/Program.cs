using System;
using System.Collections.Generic;


namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] oneToNine = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] nameray = { "Tim", "Martin", "Nikki", "Sara" };
            bool[] trueFalse = { true, false, true, false, true, false, true, false, true, false };
            List<object> iceCream = new List<object> { "Vanilla", "Mint-Chocolate Chip", "Neopolitan", "Chocolate", "Chocopolitan", "Moose Tracks", "Turtle", "French Vanilla", "Cookie Dough", "Green Tea" };
            Dictionary<string, string>
            System.Console.WriteLine(iceCream.Count);
            System.Console.WriteLine(iceCream[2]);
            iceCream[2] = "Pistachio";
            System.Console.WriteLine(iceCream[2]);
            iceCream.RemoveAt(2);
            System.Console.WriteLine(iceCream.Count);
        }
    }
}
