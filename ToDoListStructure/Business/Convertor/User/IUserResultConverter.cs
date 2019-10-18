using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.User
{
    interface IUserResultConverter
    {
        UserResult Convert(ToDoListStructure.Entities.User param);
    }
}
