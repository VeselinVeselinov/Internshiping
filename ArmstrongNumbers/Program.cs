using System;
using System.Collections.Generic;

namespace ArmstrongNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number and the console will tell you if it is Armstrong");
            int input = int.Parse(Console.ReadLine());
            int inputOriginal = input;
            List<int> inputByDigits = new List<int>();
            double sumOfDigits = 0;

            while (input > 0)
            {
                inputByDigits.Add(input % 10);
                input = input / 10;
            }

            for (int i = 0; i < inputByDigits.Count; i++)
            {
                sumOfDigits+=Math.Pow(inputByDigits[i],inputByDigits.Count);
            }

            if (sumOfDigits==inputOriginal)
            {
                Console.WriteLine("This is an Armstrong number");
            }
            else Console.WriteLine("This is not an Armstrong number");
        }
    }
}
