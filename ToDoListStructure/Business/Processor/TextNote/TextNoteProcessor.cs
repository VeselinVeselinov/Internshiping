using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Processor.TextNote
{
    class TextNoteProcessor:ITextNoteProcessor
    {
<<<<<<< Updated upstream
    }
=======
		public ITextNoteDao Dao = new TextNoteDao();

		public ITextNoteParamConverter ParamConverter = new TextNoteParamConverter();

		public ITextNoteResultConverter ResultConverter = new TextNoteResultConverter();

		public TextNoteResult Create(TextNoteParam param)
		{
			Entities.TextNote entity = ParamConverter.Convert(param);
			entity = Dao.Save(entity);
			return ResultConverter.Convert(entity);
		}

		public List<TextNoteResult> Create(List<TextNoteParam> param)
		{
			List<Entities.TextNote> entities = new List<Entities.TextNote>();
			foreach (var item in param)
			{
				entities.Add(ParamConverter.Convert(item));
			}
			Dao.Save(entities);
			List<TextNoteResult> result = new List<TextNoteResult>();
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

		public TextNoteResult Find(long id)
		{
			Entities.TextNote entity = Dao.Find(id);
			return ResultConverter.Convert(entity);
		}

		public List<TextNoteResult> Find()
		{
			List<Entities.TextNote> entities = Dao.Find();
			List<TextNoteResult> results = new List<TextNoteResult>();
			entities.ForEach(entity => results.Add(ResultConverter.Convert(entity)));
			return results;
		}

		public TextNoteResult FindByCode(string code)
		{
			return ResultConverter.Convert(Dao.FindByCode(code));
		}

		public List<TextNoteResult> FindByName(string name)
		{
			List<Entities.TextNote> entities = Dao.FindByName(name);
			List<TextNoteResult> result = new List<TextNoteResult>();
			entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));
			return result;
		}

		public void Update(long id, TextNoteParam param)
		{
			Entities.TextNote oldEntity = Dao.Find(id);
			Entities.TextNote newEntity = ParamConverter.Convert(param, oldEntity);
			Dao.Update(newEntity);
		}

		public void Update(List<TextNoteParam> param)
		{
			List<Entities.TextNote> entity = new List<Entities.TextNote>();
			param.ForEach(item => entity.Add(ParamConverter.Convert(item)));
			Dao.Update(entity);
		}
	}
>>>>>>> Stashed changes
}
