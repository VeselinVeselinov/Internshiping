using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.Category
{
    class CategoryDao:ICategoryDao
    {
<<<<<<< Updated upstream
=======
        public void Delete(long id)
        {
            Entities.Category entity = Find(id);
            Delete(entity);
        }

        public void Delete(Entities.Category entity)
        {
            CategoryData.Data.Remove(entity.Id);
        }

        public void Delete(List<long> ids)
        {
            ids.ForEach(id => Delete(id));
        }

        public Entities.Category Find(long id)
        {
            return CategoryData.Data.Values
                    .Where(entity => entity.Id.Equals(id))
                    .Single();
        }

        public List<Entities.Category> Find()
        {
            return CategoryData.Data.Values.ToList();
        }

        public Entities.Category FindByCode(string code)
        {
            return CategoryData.Data.Values
                .Where(entity => entity.Code.Equals(code))
                .Single();
        }

        public List<Entities.Category> FindByName(string name)
        {
            return CategoryData.Data.Values
                .Where(entity => entity.Name.Equals(name))
                .ToList();
        }

        public Entities.Category Save(Entities.Category entity)
        {
            CategoryData.Data.Add(entity.Id, entity);
            return entity;
        }

        public List<Entities.Category> Save(List<Entities.Category> entity)
        {
            entity.ForEach(element => Save(element));
            return entity;
        }

        public Entities.Category Update(Entities.Category entity)
        {
            Delete(entity.Id);
            Save(entity);
            return entity;
        }

        public List<Entities.Category> Update(List<Entities.Category> entity)
        {
            entity.ForEach(element => Update(element));
            return entity;
        }
>>>>>>> Stashed changes
    }
}
