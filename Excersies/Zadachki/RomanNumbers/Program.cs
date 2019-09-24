using System;
using System.Collections.Generic;

namespace RomanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number and it will be written in the Roman numeric system");
            Console.WriteLine("Note: it has to be from 1 to 3999");
            int inputNumber = int.Parse(Console.ReadLine());
            string[] firstDigits = new string[] {"I","II","III","IV","V","VI","VII","VIII","IX"};
            string[] secondDigits = new string[] { "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] thirdDigit = new string[] { "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] fourthDigit = new string[] {"M","MM","MMM" };
            List<int> inputByDigits = new List<int>();
            if (inputNumber < 0 || inputNumber > 3999)
            {
                Console.WriteLine("The number you have entered is not in the boundaries of the roman numeric system");
            }
            else
            {
                while (inputNumber > 0)
                {
                    inputByDigits.Add(inputNumber % 10);
                    inputNumber = inputNumber / 10;
                }
                Console.WriteLine("");
                Console.WriteLine("The number's written like this is the roman numeric system");
                switch (inputByDigits.Count)
                {
                    case 1:
                        WriteFirstDigit(firstDigits, inputByDigits[0] - 1);
                        break;
                    case 2:
                        WriteFirstDigit(secondDigits, inputByDigits[1] - 1);
                        WriteSecondDigit(inputByDigits[0], firstDigits);
                        break;
                    case 3:
                        WriteFirstDigit(thirdDigit, inputByDigits[2] - 1);
                        if (inputByDigits[1] == 0)
                        {
                            WriteSecondDigit(inputByDigits[0], firstDigits);
                        }
                        else
                        {
                            WriteFirstDigit(secondDigits, inputByDigits[1] - 1);
                            WriteSecondDigit(inputByDigits[0], firstDigits);
                        }
                        break;
                    case 4:
                        WriteFirstDigit(fourthDigit, inputByDigits[3] - 1);
                        if (inputByDigits[2] == 0)
                        {
                            if (inputByDigits[1] == 0)
                            {
                                WriteSecondDigit(inputByDigits[0], firstDigits);
                            }
                            else
                            {
                                WriteFirstDigit(secondDigits, inputByDigits[1] - 1);
                                WriteSecondDigit(inputByDigits[0], firstDigits);
                            }
                        }
                        else
                        {
                            WriteFirstDigit(thirdDigit, inputByDigits[2] - 1);
                            if (inputByDigits[1] == 0)
                            {
                                WriteSecondDigit(inputByDigits[0], firstDigits);
                            }
                            else
                            {
                                WriteFirstDigit(secondDigits, inputByDigits[1] - 1);
                                WriteSecondDigit(inputByDigits[0], firstDigits);
                            }
                        }
                        break;
                }
                Console.WriteLine("");
            }
        }

        static void WriteFirstDigit(string[] digitNumber,int number)
        {
            Console.Write(digitNumber[number]);
        }

        static void WriteSecondDigit(int firstDigit,string[] firstDigits)
        {
            if (firstDigit == 0)
            {
                Console.Write("");
            }
            else Console.Write(firstDigits[firstDigit - 1]);
            Console.WriteLine("");
        }
    }
}
