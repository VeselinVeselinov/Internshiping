using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Alert;
using ToDoListStructure.Data.Common;

namespace ToDoListStructure.Presentation.Service.Alert
{
    interface IAlertService
    {
        Response FindByPK(long id);

        Response ListAll();

        Response Create(AlertParam param);

        Response Create(List<AlertParam> param);

        Response Update(long id, AlertParam param);

        Response Update(List<AlertParam> param);

        Response DeleteByID(long id);

        Response Delte(List<long> idList);

        void ValidateParameters(AlertParam param);

        void ValidateParameters(List<AlertParam> param);
    }
}
