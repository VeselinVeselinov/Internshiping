using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;

namespace ToDoListStructure.Business.Convertor.Share
{
    class ShareResult:BaseResult
    {
		public long OwnerId { get; set; }

		public string OwnerName { get; set; }

		public long ContributorId { get; set; }

		public string ContributorName { get; set; }

		public long NoteId { get; set; }

		public string NoteName { get; set; }

		public long StatusId { get; set; }

		public string StatusName { get; set; }
	}
}
