using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Account;
using ToDoListStructure.Business.Processor.Account;
using ToDoListStructure.Data.Common;

namespace ToDoListStructure.Presentation.Service.Account
{
    class AccountService:IAccountService
    {
        public AccountProccesor Processor { get; set; }

        public Response Create(AccountParam param)
        {
            Processor.Create(param);
            Response response = new Response() { Text= "ailqk"};
            return response;
        }

        public Response Create(List<AccountParam> param)
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

        public Response Update(long id, AccountParam param)
        {
            throw new NotImplementedException();
        }

        public Response Update(List<AccountParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(AccountParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<AccountParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
