﻿using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;

namespace ToDoListStructure.Business.Convertor.Alert
{
    class AlertParam:BaseParamNamed
    {
		public long NoteId { get; set; }

		public DateTime TimeReminder { get; set; }

		public long StatusId { get; set; }
	}
}
