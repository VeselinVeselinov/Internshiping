using System;
using System.Collections.Generic;

namespace RemoveMatches
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> randomStrings = new List<string> {"kocho","kocho", "kocho", "kocho", "vasko","kocho","anrejko","vasko"};
            List<int> duplicatesIndexes = new List<int>();
            PrintList(randomStrings);

            for (int i = 0; i < randomStrings.Count; i++)
            {
                for (int t = i+1; t < randomStrings.Count; t++)
                {
                    if (randomStrings[i]==randomStrings[t])
                    {
                        if (!duplicatesIndexes.Contains(t))
                        {
                            duplicatesIndexes.Add(t);
                        }
                    }
                }
            }

            for (int i = 0; i < duplicatesIndexes.Count; i++)
            {
                randomStrings[duplicatesIndexes[i]] = "";
            }

            for (int i = 0; i < duplicatesIndexes.Count; i++)
            {
                randomStrings.Remove("");
            }

            Console.WriteLine("After the removal of all duplicates:");
            PrintList(randomStrings);
        }

        static void PrintList(List<string> list)
        {
            foreach (string item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }
    }
}
