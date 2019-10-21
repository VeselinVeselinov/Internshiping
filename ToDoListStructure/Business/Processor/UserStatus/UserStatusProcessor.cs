using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.UserStatus;
using ToDoListStructure.DataAccess.Dao.UserStatus;

namespace ToDoListStructure.Business.Processor.UserStatus
{
    class UserStatusProcessor:IUserStatusProcessor
    {
        public IUserStatusDao Dao { get; set; }

        public IUserStatusParamConverter ParamConverter { get; set; }

        public IUserStatusResultConverter ResultConverter { get; set; }

        public UserStatusResult Create(UserStatusParam param)
        {
            throw new NotImplementedException();
        }

        public List<UserStatusResult> Create(List<UserStatusParam> param)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public void Delete(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public UserStatusResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<UserStatusResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, UserStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<UserStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
