using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Processor.Category
{
    class CategoryProcessor:ICategoryProcessor
    {
<<<<<<< Updated upstream
=======
        public ICategoryDao Dao = new CategoryDao();

        public ICategoryParamConverter ParamConverter = new CategoryParamConverter();

        public ICategoryResultConverter ResultConverter = new CategoryResultConverter();

        public CategoryResult Create(CategoryParam param)
        {
            Entities.Category entity = ParamConverter.Convert(param);
            entity = Dao.Save(entity);
            return ResultConverter.Convert(entity);
        }

        public List<CategoryResult> Create(List<CategoryParam> param)
        {
            List<Entities.Category> entities = new List<Entities.Category>();
            foreach (var item in param)
            {
                entities.Add(ParamConverter.Convert(item));
            }
            Dao.Save(entities);
            List<CategoryResult> result = new List<CategoryResult>();
            entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));
            return result;
        }

        public void Delete(long id)
        {
            Dao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            Dao.Delete(idList);
        }

        public CategoryResult Find(long id)
        {
            Entities.Category entity = Dao.Find(id);
            return ResultConverter.Convert(entity);
        }

        public List<CategoryResult> Find()
        {
            List<Entities.Category> entities = Dao.Find();
            List<CategoryResult> results = new List<CategoryResult>();
            entities.ForEach(entity => results.Add(ResultConverter.Convert(entity)));
            return results;
        }

        public CategoryResult FindByCode(string code)
        {
            return ResultConverter.Convert(Dao.FindByCode(code));
        }

        public List<CategoryResult> FindByName(string name)
        {
            List<Entities.Category> entities = Dao.FindByName(name);
            List<CategoryResult> result = new List<CategoryResult>();
            entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));
            return result;
        }

        public void Update(long id, CategoryParam param)
        {
            Entities.Category oldEntity = Dao.Find(id);
            Entities.Category newEntity = ParamConverter.Convert(param, oldEntity);
            Dao.Update(newEntity);
        }

        public void Update(List<CategoryParam> param)
        {
            List<Entities.Category> entity = new List<Entities.Category>();
            param.ForEach(item => entity.Add(ParamConverter.Convert(item)));
            Dao.Update(entity);
        }
>>>>>>> Stashed changes
    }
}
