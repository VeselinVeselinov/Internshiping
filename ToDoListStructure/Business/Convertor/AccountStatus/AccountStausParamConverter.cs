using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.DataAccess.Dao.AccountStatus;

namespace ToDoListStructure.Business.Convertor.AccountStatus
{
    class AccountStausParamConverter:IAccountStatusParamConverter
    {
        public AccountStatusDao Dao { get; set; }
    }
}
