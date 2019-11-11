using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;
using ToDoListStructure.Data.Entity;

namespace ToDoListStructure.Business.Convertor.Alert
{
    class AlertResultConverter : BaseResultConverter<Data.Entity.Alert,AlertResult>,IAlertResultConverter
    {
		public override AlertResult ConvertSpecific(Data.Entity.Alert entity, AlertResult result)
		{
			result.NoteId = entity.Note.Id;
			result.NoteName = entity.Note.Name;
			result.StatusId = entity.Status.Id;
			result.StatusName = entity.Status.Name;

			return result;
		}

		public AlertResult Convert(Data.Entity.Alert param)
        {
			AlertResult result = ConvertStandart(param, new AlertResult());

			return ConvertSpecific(param,result);
        }
	}
}
