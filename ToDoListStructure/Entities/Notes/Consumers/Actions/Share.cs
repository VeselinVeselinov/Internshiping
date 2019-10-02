using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Entities.Notes.Consumers.Actions
{
    class Share:Persistent
    {
        public Account Owner { get; set; }
        public Account Contributor { get; set; }
        public Note SharedNote { get; set; }
    }
}
