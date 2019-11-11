using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;

namespace ToDoListStructure.Business.Convertor.Category
{
    interface ICategoryResultConverter:IBaseResultConverter<Data.Entity.Category,CategoryResult>
    {
        CategoryResult Convert(ToDoListStructure.Data.Entity.Category param);
    }
}
