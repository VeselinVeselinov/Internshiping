using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.AlertStatus
{
    class AlertStatusParamConverter:IAlertStatusParamConverter
    {
<<<<<<< Updated upstream
=======
        public IAlertStatusDao Dao = new AlertStatusDao();

        public Entities.AlertStatus Convert(AlertStatusParam param)
        {
            Entities.AlertStatus entity = new Entities.AlertStatus()
            {
				Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,
            };
            return entity;
        }

        public Entities.AlertStatus Convert(AlertStatusParam param, Entities.AlertStatus oldEntity)
        {
            Entities.AlertStatus entity = null;

            if (oldEntity != null)
            {
                entity = oldEntity;
            }
            else
            {
                entity = new Entities.AlertStatus();
            }

            entity.Name = param.Name;
            entity.Description = param.Description;

            return entity;
        }
>>>>>>> Stashed changes
    }
}
