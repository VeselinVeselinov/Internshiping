﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.UserStatus
{
    interface IUserStatusResultConverter
    {
        UserStatusResult Convert(ToDoListStructure.Entities.UserStatus param);
    }
}
