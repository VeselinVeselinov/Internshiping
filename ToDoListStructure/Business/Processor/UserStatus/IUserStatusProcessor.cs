﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Processor.UserStatus
{
    interface IUserStatusProcessor
    {
<<<<<<< Updated upstream
    }
=======
        UserStatusResult Create(UserStatusParam param);

        List<UserStatusResult> Create(List<UserStatusParam> param);

        void Update(long id, UserStatusParam param);

        void Update(List<UserStatusParam> param);

        void Delete(long id);

        void Delete(List<long> idList);

        UserStatusResult Find(long id);

        List<UserStatusResult> Find();

		UserStatusResult FindByCode(string code);

		List<UserStatusResult> FindByName(string name);
	}
>>>>>>> Stashed changes
}
