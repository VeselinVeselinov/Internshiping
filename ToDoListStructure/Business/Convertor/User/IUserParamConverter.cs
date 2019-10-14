using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.User
{
    interface IUserParamConverter
    {
        ToDoListStructure.Entities.User Convert(UserParam param);
    }
}
