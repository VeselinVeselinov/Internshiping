using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Entities.Consumers;
using ToDoListStructure.Entities.Notes;

namespace ToDoListStructure.Entities.Actions
{
    class Share:Persistent
    {
        public Account Owner { get; set; }

        public Account Contributor { get; set; }

        public Note Note { get; set; }

        public ShareStatus Status { get; set; }
    }
}
