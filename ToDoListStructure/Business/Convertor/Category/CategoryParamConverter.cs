using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.Category
{
    class CategoryParamConverter:ICategoryParamConverter
    {
<<<<<<< Updated upstream
=======
        public ICategoryDao Dao = new CategoryDao();

        public Entities.Category Convert(CategoryParam param)
        {
            Entities.Category entity = new Entities.Category()
            {
				Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,
            };
            return entity;
        }

        public Entities.Category Convert(CategoryParam param, Entities.Category oldEntity)
        {
            Entities.Category entity = null;

            if (oldEntity != null)
            {
                entity = oldEntity;
            }
            else
            {
                entity = new Entities.Category();
            }

            entity.Name = param.Name;
            entity.Description = param.Description;

            return entity;
        }
>>>>>>> Stashed changes
    }
}
