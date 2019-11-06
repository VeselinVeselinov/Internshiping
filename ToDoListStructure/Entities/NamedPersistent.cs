using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Entities
{
    class NamedPersistent : Persistent
    {
<<<<<<< Updated upstream:ToDoListStructure/Entities/NamedPersistent.cs
        protected int Code { get; set; }
=======
        public string Code { get; set; }
>>>>>>> Stashed changes:ToDoListStructure/Data/Entity/NamedPersistent.cs

        protected string Name { get; set; }

        protected string Description { get; set; }
    }
}
