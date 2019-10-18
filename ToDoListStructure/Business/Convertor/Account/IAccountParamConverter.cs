using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Entities;

namespace ToDoListStructure.Business.Convertor.Account
{
    interface IAccountParamConverter
    {
        ToDoListStructure.Entities.Account Convert(AccountParam param); 
    }
}
