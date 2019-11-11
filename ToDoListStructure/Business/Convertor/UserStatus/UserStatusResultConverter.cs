using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;
using ToDoListStructure.Data.Entity;

namespace ToDoListStructure.Business.Convertor.UserStatus
{
    class UserStatusResultConverter : BaseResultConverter<Data.Entity.UserStatus,UserStatusResult>,IUserStatusResultConverter
    {
		public override UserStatusResult ConvertSpecific(Data.Entity.UserStatus entity, UserStatusResult result)
		{
			throw new NotImplementedException();
		}

		public UserStatusResult Convert(Data.Entity.UserStatus param)
        {
			UserStatusResult result = ConvertStandart(param , new UserStatusResult());

			return result;
        }
	}
}
