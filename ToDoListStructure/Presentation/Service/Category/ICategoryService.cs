using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Category;
using ToDoListStructure.Data.Common;

namespace ToDoListStructure.Presentation.Service.Category
{
    interface ICategoryService
    {
        Response FindByPK(long id);

        Response ListAll();

        Response Create(CategoryParam param);

        Response Create(List<CategoryParam> param);

        Response Update(long id, CategoryParam param);

        Response Update(List<CategoryParam> param);

        Response DeleteByID(long id);

        Response Delte(List<long> idList);

        void ValidateParameters(CategoryParam param);

        void ValidateParameters(List<CategoryParam> param);
    }
}
