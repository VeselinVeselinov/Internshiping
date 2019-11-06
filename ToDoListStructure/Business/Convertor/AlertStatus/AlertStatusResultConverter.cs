using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.AlertStatus
{
    class AlertStatusResultConverter:IAlertStatusResultConverter
    {
<<<<<<< Updated upstream
=======
        public AlertStatusResult Convert(Entities.AlertStatus param)
        {
            AlertStatusResult result = new AlertStatusResult()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,
            };
            return result;
        }
>>>>>>> Stashed changes
    }
}
