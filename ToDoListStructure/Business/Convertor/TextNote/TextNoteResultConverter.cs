using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.TextNote
{
    class TextNoteResultConverter:ITextNoteResultConverter
    {
<<<<<<< Updated upstream
=======
        public TextNoteResult Convert(Entities.TextNote param)
        {
			TextNoteResult result = new TextNoteResult()
			{
				Id = param.Id,
				Code = param.Code,
				Name = param.Name,
				Description = param.Description,
				Content=param.Content
			};
			return result;
		}
>>>>>>> Stashed changes
    }
}
