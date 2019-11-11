using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;

namespace ToDoListStructure.Business.Convertor.User
{
    interface IUserParamConverter:IBaseParamConverter<UserParam,Data.Entity.User>
    {
        ToDoListStructure.Data.Entity.User Convert(UserParam param,Data.Entity.User oldEntity);
    }
}
