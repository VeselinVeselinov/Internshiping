using System;

namespace Temple2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number and it will create a temple with this many rows");
            int input = int.Parse(Console.ReadLine());
            ValidateAndCreate(input);
            Console.WriteLine("");
        }

        static void BaseAlgorithm(int row)
        {
            for (int i = 1; i <= 9 - row; i++)
            {
                Console.Write("  ");
            }
            for (int i = 1; i <= row; i++)
            {
                Console.Write(i + " ");
            }
            for (int i = row-1; i >= 1; i--)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine("");
        }

        static void ValidateAndCreate(int number)
        {
            if (number > 9 || number < 0)
            {
                Console.WriteLine("This number is not in the set boundaries");
                number = int.Parse(Console.ReadLine());
                ValidateAndCreate(number);
            }
            else
            {
                for (int i = 1; i <= number; i++)
                {
                    BaseAlgorithm(i);
                }
            }
        }
    }
}
