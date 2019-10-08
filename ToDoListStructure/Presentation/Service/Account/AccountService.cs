using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Processor.Account;

namespace ToDoListStructure.Presentation.Service.Account
{
    class AccountService:IAccountService
    {
        public AccountProccesor Processor { get; set; }
    }
}
