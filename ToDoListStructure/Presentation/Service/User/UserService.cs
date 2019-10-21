using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.User;
using ToDoListStructure.Business.Processor.User;
using ToDoListStructure.Data.Common;

namespace ToDoListStructure.Presentation.Service.User
{
    class UserService:IUserService
    {
        public IUserProcessor Processor { get; set; }

        public Response Create(UserParam param)
        {
            throw new NotImplementedException();
        }

        public Response Create(List<UserParam> param)
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

        public Response Update(long id, UserParam param)
        {
            throw new NotImplementedException();
        }

        public Response Update(List<UserParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(UserParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<UserParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
