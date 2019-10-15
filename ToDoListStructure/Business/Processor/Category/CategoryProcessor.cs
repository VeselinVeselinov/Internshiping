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

        public CategoryResult Create(CategoryParam param)
        {
            throw new NotImplementedException();
        }

        public List<CategoryResult> Create(List<CategoryParam> param)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public void Delete(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public CategoryResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<CategoryResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, CategoryParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<CategoryParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
