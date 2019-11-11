using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;
using ToDoListStructure.DataAccess.Dao.Category;
using ToDoListStructure.Data.Entity;

namespace ToDoListStructure.Business.Convertor.Category
{
    class CategoryParamConverter:BaseParamConverter<CategoryParam,Data.Entity.Category>,ICategoryParamConverter
    {
		public override Data.Entity.Category ConvertSpecific(CategoryParam param, Data.Entity.Category entity)
		{
			throw new NotImplementedException();
		}

		public Data.Entity.Category Convert(CategoryParam param,Data.Entity.Category oldEntity)
        {
			Data.Entity.Category entity = null;

			if (oldEntity != null)
			{
				entity = oldEntity;
			}
			else
			{
				entity = new Data.Entity.Category()
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
