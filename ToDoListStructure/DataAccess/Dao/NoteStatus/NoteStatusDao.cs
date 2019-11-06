using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.NoteStatus
{
<<<<<<< Updated upstream
    class NoteStatusDao:INoteStausDao
    {
=======
    class NoteStatusDao : INoteStausDao
    {
        public void Delete(long id)
        {
            Entities.NoteStatus entity = Find(id);
            Delete(entity);
        }

        public void Delete(Entities.NoteStatus entity)
        {
            NoteStatusData.Data.Remove(entity.Id);
        }

        public void Delete(List<long> ids)
        {
            ids.ForEach(id => Delete(id));
        }

        public Entities.NoteStatus Find(long id)
        {
            return NoteStatusData.Data.Values
                    .Where(entity => entity.Id.Equals(id))
                    .Single();
        }

        public List<Entities.NoteStatus> Find()
        {
            return NoteStatusData.Data.Values.ToList();
        }

        public Entities.NoteStatus FindByCode(string code)
        {
            return NoteStatusData.Data.Values
                .Where(entity => entity.Code.Equals(code))
                .Single();
        }

        public List<Entities.NoteStatus> FindByName(string name)
        {
            return NoteStatusData.Data.Values
                .Where(entity => entity.Name.Equals(name))
                .ToList();
        }

        public Entities.NoteStatus Save(Entities.NoteStatus entity)
        {
            NoteStatusData.Data.Add(entity.Id, entity);
            return entity;
        }

        public List<Entities.NoteStatus> Save(List<Entities.NoteStatus> entity)
        {
            entity.ForEach(element => Save(element));
            return entity;
        }

        public Entities.NoteStatus Update(Entities.NoteStatus entity)
        {
            Delete(entity.Id);
            Save(entity);
            return entity;
        }

        public List<Entities.NoteStatus> Update(List<Entities.NoteStatus> entity)
        {
            entity.ForEach(element => Update(element));
            return entity;
        }
>>>>>>> Stashed changes
    }
}
