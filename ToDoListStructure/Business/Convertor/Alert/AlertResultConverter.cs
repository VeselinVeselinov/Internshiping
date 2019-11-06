using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.Alert
{
    class AlertResultConverter:IAlertResultConverter
    {
<<<<<<< Updated upstream
=======
        public AlertResult Convert(Entities.Alert param)
        {
            AlertResult result = new AlertResult()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,
                Note = param.Note,
                TimeReminder = param.TimeReminder,
                Status = param.Status
            };
            return result;
        }
>>>>>>> Stashed changes
    }
}
