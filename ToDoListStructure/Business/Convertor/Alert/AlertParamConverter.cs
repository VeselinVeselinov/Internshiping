using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.Alert
{
    class AlertParamConverter:IAlertParamConverter
    {
<<<<<<< Updated upstream
=======
        public IAlertDao Dao = new AlertDao();

        public Entities.Alert Convert(AlertParam param)
        {
            Entities.Alert entity = new Entities.Alert()
            {
				Id = param.Id,
                Code=param.Code,
                Name=param.Name,
                Description=param.Description,
                Note=param.Note,
                TimeReminder=param.TimeReminder,
                Status=param.Status
            };
            return entity;
        }

        public Entities.Alert Convert(AlertParam param, Entities.Alert oldEntity)
        {
            Entities.Alert entity = null;

            if (oldEntity!=null)
            {
                entity = oldEntity;
            }
            else
            {
                entity = new Entities.Alert();
            }

            entity.Name = param.Name;
            entity.Description = param.Description;
            entity.Note = param.Note;
            entity.TimeReminder = param.TimeReminder;
            entity.Status = param.Status;

            return entity;
        }
>>>>>>> Stashed changes
    }
}
