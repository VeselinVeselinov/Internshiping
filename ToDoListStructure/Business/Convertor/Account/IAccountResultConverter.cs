using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;

namespace ToDoListStructure.Business.Convertor.Account
{
    interface IAccountResultConverter:IBaseResultConverter<Data.Entity.Account, AccountResult>
	{
        AccountResult Convert(Data.Entity.Account param);
    }
}
