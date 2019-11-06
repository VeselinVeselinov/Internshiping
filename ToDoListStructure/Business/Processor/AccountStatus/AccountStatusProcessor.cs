using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Processor.AccountStatus
{
    class AccountStatusProcessor:IAccountStatusProcessor
    {
<<<<<<< Updated upstream
=======
        public IAccountStatusDao Dao = new AccountStatusDao();

        public IAccountStatusResultConverter ResultConverter = new AccountStatusResultConverter();

        public IAccountStatusParamConverter ParamConverter = new AccountStausParamConverter();

        public AccountStatusResult Create(AccountStatusParam param)
        {
            Entities.AccountStatus entity = ParamConverter.Convert(param);
            entity = Dao.Save(entity);
            return ResultConverter.Convert(entity);
        }

        public List<AccountStatusResult> Create(List<AccountStatusParam> param)
        {
            List<Entities.AccountStatus> entities = new List<Entities.AccountStatus>();
            foreach (var item in param)
            {
                entities.Add(ParamConverter.Convert(item));
            }
            Dao.Save(entities);
            List<AccountStatusResult> result = new List<AccountStatusResult>();
            entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));
            return result;
        }

        public void Delete(long id)
        {
            Dao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            Dao.Delete(idList);
        }

        public AccountStatusResult Find(long id)
        {
            Entities.AccountStatus entity = Dao.Find(id);
            return ResultConverter.Convert(entity);
        }

        public List<AccountStatusResult> Find()
        {
            List<Entities.AccountStatus> entities = Dao.Find();
            List<AccountStatusResult> results = new List<AccountStatusResult>();
            entities.ForEach(entity => results.Add(ResultConverter.Convert(entity)));
            return results;
        }

        public AccountStatusResult FindByCode(string code)
        {
            return ResultConverter.Convert(Dao.FindByCode(code));
        }

        public List<AccountStatusResult> FindByName(string name)
        {
            List<Entities.AccountStatus> entities = Dao.FindByName(name);
            List<AccountStatusResult> result = new List<AccountStatusResult>();
            entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));
            return result;
        }

        public void Update(long id, AccountStatusParam param)
        {
            Entities.AccountStatus oldEntity = Dao.Find(id);
            Entities.AccountStatus newEntity = ParamConverter.Convert(param,oldEntity);
            Dao.Update(newEntity);
        }

        public void Update(List<AccountStatusParam> param)
        {
            List<Entities.AccountStatus> entity = new List<Entities.AccountStatus>();
            param.ForEach(item => entity.Add(ParamConverter.Convert(item)));
            Dao.Update(entity);
        }
>>>>>>> Stashed changes
    }
}
