using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;

namespace ToDoListStructure.Business.Convertor.AccountStatus
{
    interface IAccountStatusParamConverter:IBaseParamConverter<AccountStatusParam,Data.Entity.AccountStatus>
    {
		Data.Entity.AccountStatus Convert(AccountStatusParam param, Data.Entity.AccountStatus oldEntity);
    }
}
