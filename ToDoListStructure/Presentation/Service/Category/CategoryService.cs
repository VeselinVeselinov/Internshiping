using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Category;
using ToDoListStructure.Business.Processor.Category;
using ToDoListStructure.Data.Common;

namespace ToDoListStructure.Presentation.Service.Category
{
    class CategoryService:ICategoryService
    {
        public CategoryProcessor Processor { get; set; }

        public Response Create(CategoryParam param)
        {
            throw new NotImplementedException();
        }

        public Response Create(List<CategoryParam> param)
        {
            throw new NotImplementedException();
        }

        public Response DeleteByID(long id)
        {
            throw new NotImplementedException();
        }

        public Response Delte(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public Response FindByPK(long id)
        {
            throw new NotImplementedException();
        }

        public Response ListAll()
        {
            throw new NotImplementedException();
        }

        public Response Update(long id, CategoryParam param)
        {
            throw new NotImplementedException();
        }

        public Response Update(List<CategoryParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(CategoryParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<CategoryParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
