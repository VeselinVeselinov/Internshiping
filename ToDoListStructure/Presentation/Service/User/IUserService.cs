using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.User;
using ToDoListStructure.Data.Common;

namespace ToDoListStructure.Presentation.Service.User
{
    interface IUserService
    {
		Response FindByPK(long id);

		Response ListAll();

		Response Create(UserParam param);

		Response Create(List<UserParam> param);

		Response Update(long id, UserParam param);

		Response Update(List<UserParam> param);

		Response DeleteByID(long id);

		Response Delte(List<long> idList);

		void ValidateParameters(UserParam param);

		void ValidateParameters(List<UserParam> param);
	}
}
