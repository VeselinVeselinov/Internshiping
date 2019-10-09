using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.User;
using ToDoListStructure.DataAccess.Dao.User;

namespace ToDoListStructure.Business.Processor.User
{
    class UserProcessor:IUserProcessor
    {
        public UserDao Dao { get; set; }

        public UserParamConverter ParamConverter { get; set; }

        public UserResultConverter ResultConverter { get; set; }
    }
}
