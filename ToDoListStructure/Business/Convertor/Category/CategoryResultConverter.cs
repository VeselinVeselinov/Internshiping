using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;
using ToDoListStructure.Data.Entity;

namespace ToDoListStructure.Business.Convertor.Category
{
    class CategoryResultConverter : BaseResultConverter<Data.Entity.Category,CategoryResult>,ICategoryResultConverter
    {
		public override CategoryResult ConvertSpecific(Data.Entity.Category entity, CategoryResult result)
		{
			throw new NotImplementedException();
		}

		public CategoryResult Convert(Data.Entity.Category param)
        {
			CategoryResult result = ConvertStandart(param,new CategoryResult());
			return result;
        }
	}
}
