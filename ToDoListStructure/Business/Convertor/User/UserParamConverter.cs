using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.DataAccess.Dao.User;
using ToDoListStructure.Entities;

namespace ToDoListStructure.Business.Convertor.User
{
    class UserParamConverter:IUserParamConverter
    {
        public UserDao Dao { get; set; }

        public Entities.User Convert(UserParam param)
        {
            throw new NotImplementedException();
        }
    }
}
