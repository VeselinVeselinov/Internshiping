using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.TextNote
{
    class TextNoteParamConverter:ITextNoteParamConverter
    {
<<<<<<< Updated upstream
    }
=======
		public ITextNoteDao Dao = new TextNoteDao();

        public Entities.TextNote Convert(TextNoteParam param)
        {
			Entities.TextNote entity = new Entities.TextNote()
			{
				Id = param.Id,
				Code = param.Code,
				Name = param.Name,
				Description = param.Description,
				Content=param.Content
			};
			return entity;
		}

		public Entities.TextNote Convert(TextNoteParam param, Entities.TextNote oldEntity)
		{
			Entities.TextNote entity = null;

			if (oldEntity != null)
			{
				entity = oldEntity;
			}
			else
			{
				entity = new Entities.TextNote();
			}

			entity.Name = param.Name;
			entity.Description = param.Description;
			entity.Content = param.Content;

			return entity;
		}
	}
>>>>>>> Stashed changes
}
