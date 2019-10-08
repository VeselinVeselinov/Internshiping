using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Account;
using ToDoListStructure.DataAccess.Dao.Account;

namespace ToDoListStructure.Business.Processor.Account
{
    class AccountProccesor:IAccountProcessor
    {
        public AccountDao Dao { get; set; }

        public AccountResultConverter ResultConverter { get; set; }

        public AccountParamConverter ParamConverter { get; set; }
    }
}
