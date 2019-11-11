using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.AccountStatus;
using ToDoListStructure.DataAccess.Dao.AccountStatus;

namespace ToDoListStructure.Business.Processor.AccountStatus
{
    class AccountStatusProcessor:IAccountStatusProcessor
    {
		public IAccountStatusDao Dao = new AccountStatusDao();

		public IAccountStatusResultConverter ResultConverter = new AccountStatusResultConverter();

		public IAccountStatusParamConverter ParamConverter = new AccountStausParamConverter();

		public AccountStatusResult Create(AccountStatusParam param)
		{
			Data.Entity.AccountStatus entity = ParamConverter.Convert(param,null);
			entity = Dao.Save(entity);
			return ResultConverter.Convert(entity);
		}

		public List<AccountStatusResult> Create(List<AccountStatusParam> param)
		{
			List<Data.Entity.AccountStatus> entities = new List<Data.Entity.AccountStatus>();
			foreach (var item in param)
			{
				entities.Add(ParamConverter.Convert(item,null));
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
			Data.Entity.AccountStatus entity = Dao.Find(id);

			return ResultConverter.Convert(entity);
		}

		public List<AccountStatusResult> Find()
		{
			List<Data.Entity.AccountStatus> entities = Dao.Find();
			List<AccountStatusResult> results = new List<AccountStatusResult>();
			entities.ForEach(entity => results.Add(ResultConverter.Convert(entity)));
			return results;
		}

		public List<AccountStatusResult> FindByAttribute(string att, string value)
		{
			List<Data.Entity.AccountStatus> entities = Dao.FindByAttribute(att, value);
			List<AccountStatusResult> result = new List<AccountStatusResult>();
			entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));
			return result;
		}

		public AccountStatusResult FindByCode(string code)
		{
			return ResultConverter.Convert(Dao.FindByCode(code));
		}

		public List<AccountStatusResult> FindByName(string name)
		{
			List<Data.Entity.AccountStatus> entities = Dao.FindByName(name);
			List<AccountStatusResult> result = new List<AccountStatusResult>();
			entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));
			return result;
		}

		public void Update(long id, AccountStatusParam param)
		{
			Data.Entity.AccountStatus oldEntity = Dao.Find(id);
			Data.Entity.AccountStatus newEntity = ParamConverter.Convert(param, oldEntity);
			Dao.Update(newEntity);
		}

		public void Update(List<AccountStatusParam> param)
		{
			List<Data.Entity.AccountStatus> entity = new List<Data.Entity.AccountStatus>();
			param.ForEach(item => entity.Add(ParamConverter.Convert(item,Dao.Find(item.Id))));
			Dao.Update(entity);
		}
	}
}
