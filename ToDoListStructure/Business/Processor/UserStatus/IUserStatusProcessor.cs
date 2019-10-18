using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.UserStatus;

namespace ToDoListStructure.Business.Processor.UserStatus
{
    interface IUserStatusProcessor
    {
        UserStatusResult Create(UserStatusParam param);

        List<UserStatusResult> Create(List<UserStatusParam> param);

        void Update(long id, UserStatusParam param);

        void Update(List<UserStatusParam> param);

        void Delete(long id);

        void Delete(List<long> idList);

        UserStatusResult Find(long id);

        List<UserStatusResult> Find();
    }
}
