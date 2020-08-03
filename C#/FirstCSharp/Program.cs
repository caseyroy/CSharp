using System;

namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // loop from 1 to 5 including 5
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            // loop from 1 to 5 excluding 5
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            int j = 1;
            while (j < 6)
            {
                Console.WriteLine(j);
                j = j + 1;
            }
            Random rand = new Random();
            for (int val = 0; val < 10; val++)
            {
                //Prints the next random value between 2 and 8
                Console.WriteLine(rand.Next(2, 8));
            }

            Console.WriteLine("Hello World!");
        }
    }
}
