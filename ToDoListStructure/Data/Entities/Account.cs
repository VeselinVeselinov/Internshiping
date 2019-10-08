using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Entities.Notes;

namespace ToDoListStructure.Entities.Consumers
{
    class Account:NamedPersistent
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
