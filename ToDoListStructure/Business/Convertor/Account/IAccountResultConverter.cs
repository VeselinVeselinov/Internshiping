using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.Account
{
    interface IAccountResultConverter
    {
        AccountResult Convert(ToDoListStructure.Entities.Account param);
    }
}
