using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Account;
using ToDoListStructure.DataAccess.Dao.Account;

namespace ToDoListStructure.Business.Processor.Account
{
    class AccountProcessor:IAccountProcessor
    {
		public IAccountDao Dao = new AccountDao();

		public IAccountResultConverter ResultConverter = new AccountResultConverter();

		public IAccountParamConverter ParamConverter = new AccountParamConverter();

		public AccountResult Create(AccountParam param)
		{
			Data.Entity.Account entity = ParamConverter.Convert(param, null);

			Dao.Save(entity);

			return ResultConverter.Convert(entity);
		}

		public List<AccountResult> Create(List<AccountParam> param)
		{
			List<Data.Entity.Account> entities = new List<Data.Entity.Account>();

			foreach (var item in param)
			{
				var converted = ParamConverter.Convert(item, null);

				//if (converted.Status==null||converted.User==null)
				//{
				//	throw new InvalidOperationException();
				//}
				//else 

				entities.Add(converted);
			}

			Dao.Save(entities);

			List<AccountResult> result = new List<AccountResult>();
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

		public AccountResult Find(long id)
		{
			Data.Entity.Account entity = Dao.Find(id);

			if (entity==null)
			{
				throw new InvalidOperationException();
			}

			else return ResultConverter.Convert(entity);
		}

		public List<AccountResult> Find()
		{
			List<AccountResult> results = new List<AccountResult>();

			Dao.Find()
				.ForEach(entity => results.Add(ResultConverter.Convert(entity)));

			return results;
		}

		public List<AccountResult> FindByAttribute(string att, string value)
		{
			List<AccountResult> result = new List<AccountResult>();

			Dao.FindByAttribute(att, value)
						.ForEach(entity => result.Add(ResultConverter.Convert(entity)));

			return result;
		}

		public AccountResult FindByCode(string code)
		{
			Data.Entity.Account entity = Dao.FindByCode(code);

			return ResultConverter.Convert(entity);
		}

		public List<AccountResult> FindByName(string name)
		{
			List<AccountResult> result = new List<AccountResult>();

			Dao.FindByName(name)
						.ForEach(entity => result.Add(ResultConverter.Convert(entity)));

			return result;
		}

		public void Update(long id, AccountParam param)
		{
			Data.Entity.Account oldEntity = Dao.Find(id);

			if (oldEntity!=null)
			{
				Data.Entity.Account newEntity = ParamConverter.Convert(param, oldEntity);
				Dao.Update(newEntity);
			}
			else
			{
				throw new NullReferenceException();
			}
		}

		public void Update(List<AccountParam> param)
		{
			List<Data.Entity.Account> entity = new List<Data.Entity.Account>();

			string invalidIds = null;

			param.ForEach(item =>
			{
				if (Dao.Find(item.Id)!=null)
				{
					entity.Add(ParamConverter.Convert(item, Dao.Find(item.Id)));
				}
				else
				{
					invalidIds += item.Id.ToString() + ", ";
				}
			}
			);

			if (invalidIds!=null)
			{
				invalidIds=invalidIds.Remove(invalidIds.LastIndexOf(","));
				throw new NullReferenceException(invalidIds);
			}

			Dao.Update(entity);
		}
	}
}
