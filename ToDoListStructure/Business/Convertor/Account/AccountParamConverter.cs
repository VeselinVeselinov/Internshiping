using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.DataAccess.Dao.Account;

namespace ToDoListStructure.Business.Convertor.Account
{
    class AccountParamConverter:IAccountParamConverter
    {
        public AccountDao Dao { get; set; }
    }
}
