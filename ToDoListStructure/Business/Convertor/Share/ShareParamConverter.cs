using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;
using ToDoListStructure.DataAccess.Dao.Account;
using ToDoListStructure.DataAccess.Dao.Share;
using ToDoListStructure.DataAccess.Dao.ShareStatus;
using ToDoListStructure.Data.Entity;

namespace ToDoListStructure.Business.Convertor.Share
{
    class ShareParamConverter:BaseParamConverter<ShareParam,Data.Entity.Share>,IShareParamConverter
    {
		IAccountDao accountDao = new AccountDao();

		IShareStatusDao shareStatusDao = new ShareStatusDao();

		//note dao missing ?

		public override Data.Entity.Share ConvertSpecific(ShareParam param, Data.Entity.Share entity)
		{
			entity.Owner = accountDao.Find(param.OwnerId);
			entity.Contributor = accountDao.Find(param.ContributorId);
			entity.Status = shareStatusDao.Find(param.StatusId);

			return entity;
		}

		public Data.Entity.Share Convert(ShareParam param, Data.Entity.Share oldEntity)
		{
			Data.Entity.Share entity = null;

			if (oldEntity != null)
			{
				entity = oldEntity;
			}
			else
			{
				entity = new Data.Entity.Share()
				{
					Id=param.Id
				};
			}
			entity = ConvertSpecific(param,entity);

			return entity;
		}
	}
}
