using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Data.Common;

namespace ToDoListStructure.Data.Entity
{
    class User:Persistent
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public UserStatus Status { get; set; }
    }
}
