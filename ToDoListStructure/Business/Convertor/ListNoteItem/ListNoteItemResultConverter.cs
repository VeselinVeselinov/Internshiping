using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.ListNoteItem
{
    class ListNoteItemResultConverter:IListNoteItemResultConverter
    {
<<<<<<< Updated upstream
=======
        public ListNoteItemResult Convert(Entities.ListNoteItem param)
        {
            ListNoteItemResult result = new ListNoteItemResult()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,
                IsChecked=param.IsChecked,
                Text=param.Text
            };
            return result;
        }
>>>>>>> Stashed changes
    }
}
