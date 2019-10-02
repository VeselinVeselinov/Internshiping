using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Entities
{
    class NamedPersistent : Persistent
    {
        protected int Code { get; set; }
        protected string Name { get; set; }
        protected string Description { get; set; }
    }
}
