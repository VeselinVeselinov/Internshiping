using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.UserStatus;
using ToDoListStructure.Business.Processor.UserStatus;
using ToDoListStructure.Data.Common;

namespace ToDoListStructure.Presentation.Service.UserStatus
{
    class UserStatusService:IUserStatusService
    {
        public UserStatusProcessor Processor { get; set; }

        public Response Create(UserStatusParam param)
        {
            throw new NotImplementedException();
        }

        public Response Create(List<UserStatusParam> param)
        {
            throw new NotImplementedException();
        }

        public Response DeleteByID(long id)
        {
            throw new NotImplementedException();
        }

        public Response Delte(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public Response FindByPK(long id)
        {
            throw new NotImplementedException();
        }

        public Response ListAll()
        {
            throw new NotImplementedException();
        }

        public Response Update(long id, UserStatusParam param)
        {
            throw new NotImplementedException();
        }

        public Response Update(List<UserStatusParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(UserStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<UserStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
