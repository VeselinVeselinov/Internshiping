using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Presentation.Service.Category
{
    interface ICategoryService
    {
<<<<<<< Updated upstream
=======
        Response FindByPK(long id);

        Response ListAll();

        Response FindByCode(string code);

        Response FindByName(string name);

        Response Create(CategoryParam param);

        Response Create(List<CategoryParam> param);

        Response Update(long id, CategoryParam param);

        Response Update(List<CategoryParam> param);

        Response DeleteByID(long id);

        Response Delte(List<long> idList);

        void ValidateParameters(CategoryParam param);

        void ValidateParameters(List<CategoryParam> param);
>>>>>>> Stashed changes
    }
}
