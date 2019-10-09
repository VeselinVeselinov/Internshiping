using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.UserStatus;
using ToDoListStructure.DataAccess.Dao.UserStatus;

namespace ToDoListStructure.Business.Processor.UserStatus
{
    class UserStatusProcessor:IUserStatusProcessor
    {
        public UserStatusDao Dao { get; set; }

        public UserStatusParamConverter ParamConverter { get; set; }

        public UserStatusResultConverter ResultConverter { get; set; }
    }
}
