using System;

namespace FizzBuzz2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            number = GenerateNumber();
            Console.WriteLine(number);
            string input = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                CheckForFizzBuzz(number, input);
                if (CheckForMistake(number, input)==true)
                {
                    break;
                }
                else
                {
                    number = GenerateNumber();
                    Console.WriteLine(number);
                    input = Console.ReadLine();
                }
            }
        }

        static int GenerateNumber()
        {
            int num = 0;
            Random rand = new Random();
            num = rand.Next(1, 101);
            return num;
        }

        static void CheckForFizzBuzz(int number,string input)
        {
            if ((number % 5 == 0 && input != "fizz") || (number % 7 == 0 && input != "buzz") || (number % 35 == 0 && input != "fizzbuzz"))
            {
                Console.WriteLine("You lose");
            }
        }

        static bool CheckForMistake(int number, string input)
        {
            if ((number % 5 == 0 && input != "fizz") || (number % 7 == 0 && input != "buzz") || (number % 35 == 0 && input != "fizzbuzz"))
            {
                return true;
            }
            else return false;
        }
    }
}
