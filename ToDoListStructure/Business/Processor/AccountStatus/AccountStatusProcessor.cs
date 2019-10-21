using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.AccountStatus;
using ToDoListStructure.DataAccess.Dao.AccountStatus;

namespace ToDoListStructure.Business.Processor.AccountStatus
{
    class AccountStatusProcessor:IAccountStatusProcessor
    {
        public IAccountStatusDao Dao { get; set; }

        public IAccountStatusParamConverter ParamConverter { get; set; }

        public IAccountStatusResultConverter ResultConverter { get; set; }

        public AccountStatusResult Create(AccountStatusParam param)
        {
            throw new NotImplementedException();
        }

        public List<AccountStatusResult> Create(List<AccountStatusParam> param)
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

        public AccountStatusResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<AccountStatusResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, AccountStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<AccountStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
