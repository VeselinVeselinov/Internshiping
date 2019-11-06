using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.ImageNote
{
    class ImageNoteParamConverter:IImageNoteParamConverter
    {
<<<<<<< Updated upstream
=======
        public IImageNoteDao Dao = new ImageNoteDao();

        public Entities.ImageNote Convert(ImageNoteParam param)
        {
            Entities.ImageNote entity = new Entities.ImageNote()
            {
				Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,
                Url=param.Url,
                Text=param.Text,
                Color=param.Color,
                Account=param.Account,
                Category=param.Category,
                Status=param.Status,
                TextSize=param.TextSize
            };
            return entity;
        }

        public Entities.ImageNote Convert(ImageNoteParam param, Entities.ImageNote oldEntity)
        {
            Entities.ImageNote entity = null;

            if (oldEntity != null)
            {
                entity = oldEntity;
            }
            else
            {
                entity = new Entities.ImageNote();
            }

            entity.Name = param.Name;
            entity.Description = param.Description;
            entity.Url = param.Url;
            entity.Text = param.Text;
            entity.Color = param.Color;
            entity.Account = param.Account;
            entity.Category = param.Category;
            entity.Status = param.Status;
            entity.TextSize = param.TextSize;

            return entity;
        }
>>>>>>> Stashed changes
    }
}
