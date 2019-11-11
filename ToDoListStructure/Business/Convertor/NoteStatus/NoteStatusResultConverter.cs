using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;
using ToDoListStructure.Data.Entity;

namespace ToDoListStructure.Business.Convertor.NoteStatus
{
    class NoteStatusResultConverter : BaseResultConverter<Data.Entity.NoteStatus,NoteStatusResult>,INoteStatusResultConverter
    {
		public override NoteStatusResult ConvertSpecific(Data.Entity.NoteStatus entity, NoteStatusResult result)
		{
			throw new NotImplementedException();
		}

		public NoteStatusResult Convert(Data.Entity.NoteStatus param)
        {
			NoteStatusResult result = ConvertStandart(param, new NoteStatusResult());
			return result;
        }
	}
}
