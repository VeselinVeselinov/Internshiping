using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Presentation.Service.UserStatus
{
    interface IUserStatusService
    {
<<<<<<< Updated upstream
=======
        Response FindByPK(long id);

        Response ListAll();

		Response FindByCode(string code);

		Response FindByName(string name);

        Response Create(UserStatusParam param);

        Response Create(List<UserStatusParam> param);

        Response Update(long id, UserStatusParam param);

        Response Update(List<UserStatusParam> param);

        Response DeleteByID(long id);

        Response Delte(List<long> idList);

        void ValidateParameters(UserStatusParam param);

        void ValidateParameters(List<UserStatusParam> param);
>>>>>>> Stashed changes
    }
}
