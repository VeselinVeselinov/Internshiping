using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.Category
{
    interface ICategoryResultConverter
    {
        CategoryResult Convert(ToDoListStructure.Entities.Category param);
    }
}
