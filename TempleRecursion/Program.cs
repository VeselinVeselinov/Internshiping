using System;

namespace TempleRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number and a temple with that many rows will appear.");
            Console.WriteLine("Note: the number has to be between 1 and 9!");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            int rowStarter = 1;
            ValidateAndCreate(rows,rowStarter);
            Console.WriteLine(" ");
        }

        static void BaseAlgorithm(int rowsTotal,int rowStarter)
        {
            while (rowStarter<=rowsTotal)
            {
                WriteEmptySpace(rowStarter);
                WriteNumbers(1, rowStarter);
                rowStarter++;
                BaseAlgorithm(rowsTotal,rowStarter);
                break;
            }
        }

        static void WriteEmptySpace(int currentRow)
        {
            for (int i = 1; i <= 9 - currentRow; i++)
            {
                Console.Write("  ");
            }
        }

        static void WriteNumbers(int start,int end)
        {
            int i;
            for (i = start; i <= end; i++)
            {
                Console.Write(Math.Abs(i) + " ");
            }
            if (i==(end+start))
            {
                WriteNumbers(-(end - start),-start);
            }
            else
            {
                Console.WriteLine("");
            }
        }

        static void ValidateAndCreate(int rows, int rowStarter)
        {
            if (rows > 9 || rows < 0)
            {
                Console.WriteLine("This number is not in the set boundaries");
                rows = int.Parse(Console.ReadLine());
                ValidateAndCreate(rows,rowStarter);
            }
            else
            {
                BaseAlgorithm(rows, rowStarter);
            }
        }

    }
}
