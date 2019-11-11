using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;

namespace ToDoListStructure.Business.Convertor.AccountStatus
{
    interface IAccountStatusResultConverter: IBaseResultConverter<Data.Entity.AccountStatus,AccountStatusResult>
	{
        AccountStatusResult Convert(Data.Entity.AccountStatus param);
    }
}
