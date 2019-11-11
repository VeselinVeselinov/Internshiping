using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Data.Common;

namespace ToDoListStructure.Data.Entity
{
    class Account:PersistentNamed
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public User User { get; set; }

        public AccountStatus Status { get; set; }
    }
}
