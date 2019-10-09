using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Processor.UserStatus;

namespace ToDoListStructure.Presentation.Service.UserStatus
{
    class UserStatusService:IUserStatusService
    {
        public UserStatusProcessor Processor { get; set; }
    }
}
