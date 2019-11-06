using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.User
{
    class UserResultConverter:IUserResultConverter
    {
<<<<<<< Updated upstream
=======
        public UserResult Convert(Entities.User param)
        {
			UserResult result = new UserResult()
			{
				Id = param.Id,
				UserName = param.UserName,
				Password = param.Password,
				Status = param.Status,
			};
			return result;
		}
>>>>>>> Stashed changes
    }
}
