using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;
using ToDoListStructure.DataAccess.Dao.Alert;
using ToDoListStructure.Data.Entity;

namespace ToDoListStructure.Business.Convertor.Alert
{
    class AlertParamConverter:BaseParamConverter<AlertParam,Data.Entity.Alert>,IAlertParamConverter
    {
		public override Data.Entity.Alert ConvertSpecific(AlertParam param, Data.Entity.Alert entity)
		{
			throw new NotImplementedException();
		}

		public Data.Entity.Alert Convert(AlertParam param, Data.Entity.Alert oldEntity)
		{
			Data.Entity.Alert entity = null;

			if (oldEntity != null)
			{
				entity = oldEntity;
			}
			else
			{
				entity = new Data.Entity.Alert()
				{
					Id=param.Id,
					Code=param.Code
				};
			}

			entity.Name = param.Name;
			entity.Description = param.Description;
			//entity.Note = param.Note;
			entity.TimeReminder = param.TimeReminder;
			//entity.Status = param.Status;

			return entity;
		}
	}
}
