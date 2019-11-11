using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;

namespace ToDoListStructure.Business.Convertor.User
{
    class UserResult:BaseResult
    {
		public string UserName { get; set; }

		public string Password { get; set; }

		public long StatusId { get; set; }

		public string StatusName { get; set; }
	}
}
