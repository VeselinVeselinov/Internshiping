using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.ListNoteItem
{
    class ListNoteItemDao:IListNoteItemDao
    {
<<<<<<< Updated upstream
=======
        public void Delete(long id)
        {
            Entities.ListNoteItem entity = Find(id);
            Delete(entity);
        }

        public void Delete(Entities.ListNoteItem entity)
        {
            ListNoteItemData.Data.Remove(entity.Id);
        }

        public void Delete(List<long> ids)
        {
            ids.ForEach(id => Delete(id));
        }

        public Entities.ListNoteItem Find(long id)
        {
            return ListNoteItemData.Data.Values
                    .Where(entity => entity.Id.Equals(id))
                    .Single();
        }

        public List<Entities.ListNoteItem> Find()
        {
            return ListNoteItemData.Data.Values.ToList();
        }

        public Entities.ListNoteItem FindByCode(string code)
        {
            return ListNoteItemData.Data.Values
                .Where(entity => entity.Code.Equals(code))
                .Single();
        }

        public List<Entities.ListNoteItem> FindByName(string name)
        {
            return ListNoteItemData.Data.Values
                .Where(entity => entity.Name.Equals(name))
                .ToList();
        }

        public Entities.ListNoteItem Save(Entities.ListNoteItem entity)
        {
            ListNoteItemData.Data.Add(entity.Id, entity);
            return entity;
        }

        public List<Entities.ListNoteItem> Save(List<Entities.ListNoteItem> entity)
        {
            entity.ForEach(element => Save(element));
            return entity;
        }

        public Entities.ListNoteItem Update(Entities.ListNoteItem entity)
        {
            Delete(entity.Id);
            Save(entity);
            return entity;
        }

        public List<Entities.ListNoteItem> Update(List<Entities.ListNoteItem> entity)
        {
            entity.ForEach(element => Update(element));
            return entity;
        }
>>>>>>> Stashed changes
    }
}
