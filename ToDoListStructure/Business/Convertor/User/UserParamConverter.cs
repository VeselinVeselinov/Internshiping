using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.DataAccess.Dao.User;

namespace ToDoListStructure.Business.Convertor.User
{
    class UserParamConverter:IUserParamConverter
    {
        public UserDao Dao { get; set; }
    }
}
