using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.DataAccess.Dao.UserStatus;
using ToDoListStructure.Entities;

namespace ToDoListStructure.Business.Convertor.UserStatus
{
    class UserStatusParamConverter:IUserStatusParamConverter
    {
        public IUserStatusDao Dao { get; set; }

        public Entities.UserStatus Convert(UserStatusParam param)
        {
            throw new NotImplementedException();
        }
    }
}
