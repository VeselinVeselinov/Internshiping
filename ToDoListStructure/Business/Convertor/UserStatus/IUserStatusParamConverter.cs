using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;

namespace ToDoListStructure.Business.Convertor.UserStatus
{
    interface IUserStatusParamConverter:IBaseParamConverter<UserStatusParam,Data.Entity.UserStatus>
    {
        ToDoListStructure.Data.Entity.UserStatus Convert(UserStatusParam param, Data.Entity.UserStatus oldEntity);
    }
}
