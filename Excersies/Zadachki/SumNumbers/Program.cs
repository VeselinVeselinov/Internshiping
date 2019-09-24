using System;
using System.Collections.Generic;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(IterationSumming(input));
            Console.WriteLine(RecursiveSumming(input));
        }

        static int IterationSumming(int input)
        {
            int sum = 0;
            while (input>0)
            {
                sum += input % 10;
                input = input / 10;
            }
            return sum;
        }

        static int RecursiveSumming(int input)
        {
            int sum = input % 10;
            input = input / 10;
            if (input>0)
            {
                return sum += RecursiveSumming(input);
            }
            return sum;
        }
    }
}
