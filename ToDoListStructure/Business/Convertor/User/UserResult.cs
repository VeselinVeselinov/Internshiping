﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.User
{
    class UserResult:BaseResult
    {
		public string UserName { get; set; }

		public string Password { get; set; }

		public Entities.UserStatus Status { get; set; }
	}
}
