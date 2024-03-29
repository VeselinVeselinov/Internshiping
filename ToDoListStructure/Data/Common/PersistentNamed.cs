﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Data.Common
{
    class PersistentNamed : Persistent
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
