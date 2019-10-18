using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.Account
{
    class AccountParam:BaseParamNamed
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public Entities.User User { get; set; }

        public Entities.AccountStatus Status { get; set; }
    }
}
