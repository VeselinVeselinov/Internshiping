using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.AccountStatus;
using ToDoListStructure.DataAccess.Dao.AccountStatus;

namespace ToDoListStructure.Business.Processor.AccountStatus
{
    class AccountStatusProcessor:IAccountStatusProcessor
    {
        public AccountStatusDao Dao { get; set; }

        public AccountStausParamConverter ParamConverter { get; set; }

        public AccountStatusResultConverter ResultConverter { get; set; }
    }
}
