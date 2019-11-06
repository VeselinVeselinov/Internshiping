using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.ImageNote
{
    class ImageNoteResultConverter:IImageNoteResultConverter
    {
<<<<<<< Updated upstream
=======
        public ImageNoteResult Convert(Entities.ImageNote param)
        {
            ImageNoteResult result = new ImageNoteResult()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,
                Url = param.Url,
                Text = param.Text,
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
