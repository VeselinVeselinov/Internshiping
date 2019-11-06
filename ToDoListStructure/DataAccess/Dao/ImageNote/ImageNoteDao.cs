using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.ImageNote
{
    class ImageNoteDao:IImageNoteDao
    {
<<<<<<< Updated upstream
=======
        public void Delete(long id)
        {
            Entities.ImageNote entity = Find(id);
            Delete(entity);
        }

        public void Delete(Entities.ImageNote entity)
        {
            ImageNoteData.Data.Remove(entity.Id);
        }

        public void Delete(List<long> ids)
        {
            ids.ForEach(id => Delete(id));
        }

        public Entities.ImageNote Find(long id)
        {
            return ImageNoteData.Data.Values
                    .Where(entity => entity.Id.Equals(id))
                    .Single();
        }

        public List<Entities.ImageNote> Find()
        {
            return ImageNoteData.Data.Values.ToList();
        }

        public Entities.ImageNote FindByCode(string code)
        {
            return ImageNoteData.Data.Values
                .Where(entity => entity.Code.Equals(code))
                .Single();
        }

        public List<Entities.ImageNote> FindByName(string name)
        {
            return ImageNoteData.Data.Values
                .Where(entity => entity.Name.Equals(name))
                .ToList();
        }

        public Entities.ImageNote Save(Entities.ImageNote entity)
        {
            ImageNoteData.Data.Add(entity.Id, entity);
            return entity;
        }

        public List<Entities.ImageNote> Save(List<Entities.ImageNote> entity)
        {
            entity.ForEach(element => Save(element));
            return entity;
        }

        public Entities.ImageNote Update(Entities.ImageNote entity)
        {
            Delete(entity.Id);
            Save(entity);
            return entity;
        }

        public List<Entities.ImageNote> Update(List<Entities.ImageNote> entity)
        {
            entity.ForEach(element => Update(element));
            return entity;
        }
>>>>>>> Stashed changes
    }
}
