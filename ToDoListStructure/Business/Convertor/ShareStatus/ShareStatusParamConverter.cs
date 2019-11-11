using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;
using ToDoListStructure.DataAccess.Dao.ShareStatus;
using ToDoListStructure.Data.Entity;

namespace ToDoListStructure.Business.Convertor.ShareStatus
{
    class ShareStatusParamConverter:BaseParamConverter<ShareStatusParam,Data.Entity.ShareStatus>,IShareStatusParamConverter
    {
		public override Data.Entity.ShareStatus ConvertSpecific(ShareStatusParam param, Data.Entity.ShareStatus entity)
		{
			throw new NotImplementedException();
		}

		public Data.Entity.ShareStatus Convert(ShareStatusParam param, Data.Entity.ShareStatus oldEntity)
        {
			Data.Entity.ShareStatus entity = null;

			if (oldEntity != null)
			{
				entity = oldEntity;
			}
			else
			{
				entity = new Data.Entity.ShareStatus()
				{
					Id=param.Id,
					Code=param.Code
				};
			}

			entity.Name = param.Name;
			entity.Description = param.Description;

			return entity;
		}
	}
}
