using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Processor.User;

namespace ToDoListStructure.Presentation.Service.User
{
    class UserService:IUserService
    {
        public UserProcessor Processor { get; set; }
    }
}
