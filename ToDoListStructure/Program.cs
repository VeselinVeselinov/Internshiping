using System;
using ToDoListStructure.Entities.Notes;
using ToDoListStructure.Entities.Actions;
using ToDoListStructure.Entities.Consumers;

namespace ToDoListStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Account Vesko = new Account();
            Account Vasko = new Account();
            TextNote Note1 = new TextNote();
            Note1.Content = "Today i will order pizza";
            Console.WriteLine(Note1.Content);

            Share spodelqnka = new Share();
            

            Console.WriteLine();
            
        }
    }
}
