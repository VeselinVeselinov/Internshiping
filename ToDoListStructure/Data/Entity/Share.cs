using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Data.Common;

namespace ToDoListStructure.Data.Entity
{
    class Share:Persistent
    {
        public Account Owner { get; set; }

        public Account Contributor { get; set; }

        public Note Note { get; set; }

        public ShareStatus Status { get; set; }
    }
}
