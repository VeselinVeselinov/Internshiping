using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.ListNote
{
    class ListNoteParamConverter:IListNoteParamConverter
    {
<<<<<<< Updated upstream
=======
        public IListNoteDao Dao = new ListNoteDao();

        public Entities.ListNote Convert(ListNoteParam param)
        {
            Entities.ListNote entity = new Entities.ListNote()
            {
				Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,
                Content = param.Content,
                Color = param.Color,
                Account = param.Account,
                Category = param.Category,
                Status = param.Status,
                TextSize = param.TextSize
            };
            return entity;
        }

        public Entities.ListNote Convert(ListNoteParam param, Entities.ListNote oldEntity)
        {
            Entities.ListNote entity = null;

            if (oldEntity != null)
            {
                entity = oldEntity;
            }
            else
            {
                entity = new Entities.ListNote();
            }

            entity.Name = param.Name;
            entity.Description = param.Description;
            entity.Content = param.Content;
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
