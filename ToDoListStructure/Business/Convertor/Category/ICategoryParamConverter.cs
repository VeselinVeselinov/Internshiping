using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;

namespace ToDoListStructure.Business.Convertor.Category
{
    interface ICategoryParamConverter:IBaseParamConverter<CategoryParam,Data.Entity.Category>
    {
        ToDoListStructure.Data.Entity.Category Convert(CategoryParam param,Data.Entity.Category oldEntity);
    }
}
