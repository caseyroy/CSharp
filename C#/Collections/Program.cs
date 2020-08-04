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
            string[] namearray = { "Tim", "Martin", "Nikki", "Sara" };
            bool[] trueFalse = { true, false, true, false, true, false, true, false, true, false };
            List<string> iceCream = new List<string>
            {
                "Vanilla",
                "Mint-Chocolate Chip",
                "Neopolitan",
                "Chocolate",
                "Chocopolitan",
                "Moose Tracks",
                "Turtle",
                "French Vanilla",
                "Cookie Dough",
                "Green Tea"
                };
            Dictionary<string, string> favorites = new Dictionary<string, string>();
            foreach (string item in namearray)
            {
                favorites.Add(item, iceCream[RandomFlavor(iceCream)]);
                System.Console.WriteLine(item + ":" + favorites[item]);
            }
            // System.Console.WriteLine(iceCream.Count);
            // System.Console.WriteLine(iceCream[2]);
            // iceCream[2] = "Pistachio";
            // System.Console.WriteLine(iceCream[2]);
            // iceCream.RemoveAt(2);
            // System.Console.WriteLine(iceCream.Count);
        }
        public static int RandomFlavor(List<string> flavors)
        {
            Random rand = new Random();
            int flavor = rand.Next(0, flavors.Count);
            return flavor;
        }
    }
}
