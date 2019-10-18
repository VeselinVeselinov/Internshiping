using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.DataAccess.Dao.Category;
using ToDoListStructure.Entities;

namespace ToDoListStructure.Business.Convertor.Category
{
    class CategoryParamConverter:ICategoryParamConverter
    {
        public CategoryDao Dao { get; set; }

        public Entities.Category Convert(CategoryParam param)
        {
            throw new NotImplementedException();
        }
    }
}
