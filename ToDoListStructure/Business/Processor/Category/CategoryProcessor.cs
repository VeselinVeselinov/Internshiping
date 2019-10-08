using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Category;
using ToDoListStructure.DataAccess.Dao.Category;

namespace ToDoListStructure.Business.Processor.Category
{
    class CategoryProcessor:ICategoryProcessor
    {
        public CategoryDao Dao { get; set; }

        public CategoryParamConverter ParamConverter { get; set; }

        public CategoryResultConverter ResultConverter { get; set; }
    }
}
