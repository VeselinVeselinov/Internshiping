using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;
using ToDoListStructure.DataAccess.Dao.AlertStatus;
using ToDoListStructure.Data.Entity;

namespace ToDoListStructure.Business.Convertor.AlertStatus
{
    class AlertStatusParamConverter: BaseParamConverter<AlertStatusParam,Data.Entity.AlertStatus>,IAlertStatusParamConverter
    {
		public override Data.Entity.AlertStatus ConvertSpecific(AlertStatusParam param, Data.Entity.AlertStatus entity)
		{
			throw new NotImplementedException();
		}

		public Data.Entity.AlertStatus Convert(AlertStatusParam param, Data.Entity.AlertStatus oldEntity)
		{
            Data.Entity.AlertStatus entity = null;

            if (oldEntity != null)
            {
                entity = oldEntity;
            }
            else
            {
                entity = new Data.Entity.AlertStatus()
				{
					Id =param.Id,
					Code=param.Code
				};
            }

            entity.Name = param.Name;
            entity.Description = param.Description;

            return entity;
		}
	}
}
