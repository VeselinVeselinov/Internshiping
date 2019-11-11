using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;

namespace ToDoListStructure.Business.Convertor.Account
{
    class AccountParam:BaseParamNamed
    {
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Address { get; set; }

		public string Phone { get; set; }

		public string Email { get; set; }

		public long UserId { get; set; }

		public long StatusId { get; set; }
	}
}
