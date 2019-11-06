using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.Category
{
    class CategoryResultConverter:ICategoryResultConverter
    {
<<<<<<< Updated upstream
=======
        public CategoryResult Convert(Entities.Category param)
        {
            CategoryResult result = new CategoryResult()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,
            };
            return result;
        }
>>>>>>> Stashed changes
    }
}
