using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Account;

namespace ToDoListStructure.Business.Convertor.AccountStatus
{
    interface IAccountStatusParamConverter
    {
        ToDoListStructure.Entities.Account Convert(AccountParam param);
    }
}
