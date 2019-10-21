using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Account;
using ToDoListStructure.DataAccess.Dao.AccountStatus;
using ToDoListStructure.Entities;

namespace ToDoListStructure.Business.Convertor.AccountStatus
{
    class AccountStausParamConverter:IAccountStatusParamConverter
    {
        public IAccountStatusDao Dao { get; set; }

        public Entities.Account Convert(AccountParam param)
        {
            throw new NotImplementedException();
        }
    }
}
