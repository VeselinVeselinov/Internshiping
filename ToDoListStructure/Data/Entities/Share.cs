using System;
using System.Collections.Generic;
using System.Text;


namespace ToDoListStructure.Entities
{
    class Share:Persistent
    {
        public Account Owner { get; set; }

        public Account Contributor { get; set; }

        public Note Note { get; set; }

        public ShareStatus Status { get; set; }
    }
}
