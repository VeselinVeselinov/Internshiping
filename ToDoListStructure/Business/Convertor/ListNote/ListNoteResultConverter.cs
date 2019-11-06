using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.ListNote
{
    class ListNoteResultConverter:IListNoteResultConverter
    {
<<<<<<< Updated upstream
=======
        public ListNoteResult Convert(Entities.ListNote param)
        {
            ListNoteResult result = new ListNoteResult()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,
                Content=param.Content,
                Color = param.Color,
                Account = param.Account,
                Category = param.Category,
                Status = param.Status,
                TextSize = param.TextSize
            };
            return result;
        }
>>>>>>> Stashed changes
    }
}
