using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Processor.AccountStatus;

namespace ToDoListStructure.Presentation.Service.AccountStatus
{
    class AccountStatusService:IAccountStatusService
    {
        public AccountStatusProcessor Processor { get; set; }
    }
}
