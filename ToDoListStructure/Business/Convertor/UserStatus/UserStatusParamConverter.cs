using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.DataAccess.Dao.UserStatus;

namespace ToDoListStructure.Business.Convertor.UserStatus
{
    class UserStatusParamConverter:IUserStatusParamConverter
    {
        public UserStatusDao Dao { get; set; }
    }
}
