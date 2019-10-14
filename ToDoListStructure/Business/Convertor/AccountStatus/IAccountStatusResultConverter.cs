using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.AccountStatus
{
    interface IAccountStatusResultConverter
    {
        AccountStatusResult Convert(ToDoListStructure.Entities.AccountStatus param);
    }
}
