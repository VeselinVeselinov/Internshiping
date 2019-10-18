﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Entities
{
    class NamedPersistent : Persistent
    {
        public int Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
