using System;

namespace FizzBuzz3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 5 == 0)
                {
                    if (number%7==0)
                    {
                        Console.WriteLine("fizzbuzz");
                    }
                    else Console.WriteLine("fizz");
                }
                else if (number % 7 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine("No, fizzbuzz around here!");
                }
            }
        }
    }
}
