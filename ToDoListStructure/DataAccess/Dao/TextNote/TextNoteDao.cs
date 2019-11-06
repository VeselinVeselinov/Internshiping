using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoListStructure.DataAccess.Dao.TextNote
{
    class TextNoteDao:ITextNoteDao
    {
<<<<<<< Updated upstream
    }
=======
		public void Delete(long id)
		{
			Entities.TextNote entity = Find(id);
			Delete(entity);
		}

		public void Delete(Entities.TextNote entity)
		{
			TextNoteData.Data.Remove(entity.Id);
		}

		public void Delete(List<long> ids)
		{
			ids.ForEach(id => Delete(id));
		}

		public Entities.TextNote Find(long id)
		{
			return TextNoteData.Data.Values
					.Where(entity => entity.Id.Equals(id))
					.Single();
		}

		public List<Entities.TextNote> Find()
		{
			return TextNoteData.Data.Values.ToList();
		}

		public Entities.TextNote FindByCode(string code)
		{
			return TextNoteData.Data.Values
				.Where(entity => entity.Code.Equals(code))
				.Single();
		}

		public List<Entities.TextNote> FindByName(string name)
		{
			return TextNoteData.Data.Values
				.Where(entity => entity.Name.Equals(name))
				.ToList();
		}

		public Entities.TextNote Save(Entities.TextNote entity)
		{
			TextNoteData.Data.Add(entity.Id, entity);
			return entity;
		}

		public List<Entities.TextNote> Save(List<Entities.TextNote> entity)
		{
			entity.ForEach(element => Save(element));
			return entity;
		}

		public Entities.TextNote Update(Entities.TextNote entity)
		{
			Delete(entity.Id);
			Save(entity);
			return entity;
		}

		public List<Entities.TextNote> Update(List<Entities.TextNote> entity)
		{
			entity.ForEach(element => Update(element));
			return entity;
		}
	}
>>>>>>> Stashed changes
}
