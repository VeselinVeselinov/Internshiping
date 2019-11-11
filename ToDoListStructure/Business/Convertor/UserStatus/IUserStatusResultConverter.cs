using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;

namespace ToDoListStructure.Business.Convertor.UserStatus
{
    interface IUserStatusResultConverter:IBaseResultConverter<Data.Entity.UserStatus,UserStatusResult>
    {
        UserStatusResult Convert(ToDoListStructure.Data.Entity.UserStatus param);
    }
}
