using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;
using ToDoListStructure.Data.Entity;

namespace ToDoListStructure.Business.Convertor.User
{
    class UserResultConverter : BaseResultConverter<Data.Entity.User,UserResult>,IUserResultConverter
    {
		public override UserResult ConvertSpecific(Data.Entity.User entity, UserResult result)
		{
			result.StatusId = entity.Status.Id;
			result.StatusName = entity.Status.Name;

			return result;
		}

		public UserResult Convert(Data.Entity.User param)
        {
			UserResult result = ConvertStandart(param, new UserResult());

			return ConvertSpecific(param,result);
        }
	}
}
