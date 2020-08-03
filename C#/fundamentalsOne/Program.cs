using System;

namespace fundamentalsOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // int i = 1;
            // while (i <= 255)
            // {
            //     System.Console.WriteLine(i);
            //     i++;
            // }
            int j = 1;
            while (j <= 100)
            // for (int j = 1; j <= 100; j++)
            {
                if (j % 3 == 0 && j % 5 == 0)
                {
                    System.Console.WriteLine("FizzBuzz");
                    System.Console.WriteLine(j);
                }
                else if (j % 3 == 0)
                {
                    System.Console.WriteLine("Fizz");
                    System.Console.WriteLine(j);
                }
                else if (j % 5 == 0)
                {
                    System.Console.WriteLine("Buzz");
                    System.Console.WriteLine(j);
                }
                j++;
            }
            Console.WriteLine("Hello World!");
        }
    }
}
