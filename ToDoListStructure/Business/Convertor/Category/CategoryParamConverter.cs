using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.DataAccess.Dao.Category;

namespace ToDoListStructure.Business.Convertor.Category
{
    class CategoryParamConverter:ICategoryParamConverter
    {
        public CategoryDao Dao { get; set; }
    }
}
