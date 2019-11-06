using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Presentation.Service.AlertStatus
{
    interface IAlertStatusService
    {
<<<<<<< Updated upstream
=======
        Response FindByPK(long id);

        Response ListAll();

        Response FindByCode(string code);

        Response FindByName(string name);

        Response Create(AlertStatusParam param);

        Response Create(List<AlertStatusParam> param);

        Response Update(long id, AlertStatusParam param);

        Response Update(List<AlertStatusParam> param);

        Response DeleteByID(long id);

        Response Delte(List<long> idList);

        void ValidateParameters(AlertStatusParam param);

        void ValidateParameters(List<AlertStatusParam> param);
>>>>>>> Stashed changes
    }
}
