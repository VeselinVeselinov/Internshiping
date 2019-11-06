using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Presentation.Service.ShareStatus
{
    interface IShareStatusService
    {
<<<<<<< Updated upstream
=======
        Response FindByPK(long id);

        Response ListAll();

		Response FindByCode(string code);

		Response FindByName(string name);

		Response Create(ShareStatusParam param);

        Response Create(List<ShareStatusParam> param);

        Response Update(long id, ShareStatusParam param);

        Response Update(List<ShareStatusParam> param);

        Response DeleteByID(long id);

        Response Delte(List<long> idList);

        void ValidateParameters(ShareStatusParam param);

        void ValidateParameters(List<ShareStatusParam> param);
>>>>>>> Stashed changes
    }
}
