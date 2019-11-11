using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;

namespace ToDoListStructure.Business.Convertor.User
{
    interface IUserResultConverter:IBaseResultConverter<Data.Entity.User,UserResult>
    {
        UserResult Convert(ToDoListStructure.Data.Entity.User param);
    }
}
