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
            ImageNote image = new ImageNote();
            Share spodelqnka = new Share();
            spodelqnka.Note = image;
            Console.WriteLine(typeof(Share));
            
        }
    }
}
