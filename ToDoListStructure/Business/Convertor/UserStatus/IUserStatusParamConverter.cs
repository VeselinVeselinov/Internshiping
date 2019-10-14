using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.UserStatus
{
    interface IUserStatusParamConverter
    {
        ToDoListStructure.Entities.UserStatus Convert(UserStatusParam param);
    }
}
