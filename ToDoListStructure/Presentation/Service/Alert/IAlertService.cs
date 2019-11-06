using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Presentation.Service.Alert
{
    interface IAlertService
    {
<<<<<<< Updated upstream
=======
        Response FindByPK(long id);

        Response FindByCode(string code);

        Response FindByName(string name);

        Response ListAll();

        Response Create(AlertParam param);

        Response Create(List<AlertParam> param);

        Response Update(long id, AlertParam param);

        Response Update(List<AlertParam> param);

        Response DeleteByID(long id);

        Response Delte(List<long> idList);

        void ValidateParameters(AlertParam param);

        void ValidateParameters(List<AlertParam> param);
>>>>>>> Stashed changes
    }
}
