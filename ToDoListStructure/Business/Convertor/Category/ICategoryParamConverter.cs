using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.Category
{
    interface ICategoryParamConverter
    {
        ToDoListStructure.Entities.Category Convert(CategoryParam param);
    }
}
