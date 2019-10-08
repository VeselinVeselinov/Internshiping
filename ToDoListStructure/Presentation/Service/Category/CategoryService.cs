using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Processor.Category;

namespace ToDoListStructure.Presentation.Service.Category
{
    class CategoryService:ICategoryService
    {
        public CategoryProcessor Processor { get; set; }
    }
}
