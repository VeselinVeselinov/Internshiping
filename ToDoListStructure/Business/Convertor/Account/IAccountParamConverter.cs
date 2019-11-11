using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;

namespace ToDoListStructure.Business.Convertor.Account
{
    interface IAccountParamConverter : IBaseParamConverter<AccountParam, Data.Entity.Account>
	{
		Data.Entity.Account Convert(AccountParam param, Data.Entity.Account entity);
    }
}
