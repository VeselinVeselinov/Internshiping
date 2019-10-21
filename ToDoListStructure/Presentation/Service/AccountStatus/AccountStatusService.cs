using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.AccountStatus;
using ToDoListStructure.Business.Processor.AccountStatus;
using ToDoListStructure.Data.Common;

namespace ToDoListStructure.Presentation.Service.AccountStatus
{
    class AccountStatusService:IAccountStatusService
    {
        public IAccountStatusProcessor Processor { get; set; }

        public Response Create(AccountStatusParam param)
        {
            throw new NotImplementedException();
        }

        public Response Create(List<AccountStatusParam> param)
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

        public Response Update(long id, AccountStatusParam param)
        {
            throw new NotImplementedException();
        }

        public Response Update(List<AccountStatusParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(AccountStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<AccountStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
