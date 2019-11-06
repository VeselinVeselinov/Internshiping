using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.ListNote
{
    class ListNoteDao:IListNoteDao
    {
<<<<<<< Updated upstream
=======
        public void Delete(long id)
        {
            Entities.ListNote entity = Find(id);
            Delete(entity);
        }

        public void Delete(Entities.ListNote entity)
        {
            ListNoteData.Data.Remove(entity.Id);
        }

        public void Delete(List<long> ids)
        {
            ids.ForEach(id => Delete(id));
        }

        public Entities.ListNote Find(long id)
        {
            return ListNoteData.Data.Values
                    .Where(entity => entity.Id.Equals(id))
                    .Single();
        }

        public List<Entities.ListNote> Find()
        {
            return ListNoteData.Data.Values.ToList();
        }

        public Entities.ListNote FindByCode(string code)
        {
            return ListNoteData.Data.Values
                .Where(entity => entity.Code.Equals(code))
                .Single();
        }

        public List<Entities.ListNote> FindByName(string name)
        {
            return ListNoteData.Data.Values
                .Where(entity => entity.Name.Equals(name))
                .ToList();
        }

        public Entities.ListNote Save(Entities.ListNote entity)
        {
            ListNoteData.Data.Add(entity.Id, entity);
            return entity;
        }

        public List<Entities.ListNote> Save(List<Entities.ListNote> entity)
        {
            entity.ForEach(element => Save(element));
            return entity;
        }

        public Entities.ListNote Update(Entities.ListNote entity)
        {
            Delete(entity.Id);
            Save(entity);
            return entity;
        }

        public List<Entities.ListNote> Update(List<Entities.ListNote> entity)
        {
            entity.ForEach(element => Update(element));
            return entity;
        }
>>>>>>> Stashed changes
    }
}
