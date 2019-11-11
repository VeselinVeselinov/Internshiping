using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;

namespace ToDoListStructure.Business.Convertor.Share
{
    class ShareParam:BaseParam
    {
		public long OwnerId { get; set; }

		public long ContributorId { get; set; }

		public long NoteId { get; set; }

		public long StatusId { get; set; }
	}
}
