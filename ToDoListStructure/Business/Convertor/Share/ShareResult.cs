using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.Share
{
    class ShareResult:BaseResult
    {
		public Entities.Account Owner { get; set; }

		public Entities.Account Contributor { get; set; }

		public Entities.Note Note { get; set; }

		public Entities.ShareStatus Status { get; set; }
	}
}
