using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.ListNoteItem
{
    class ListNoteItemParamConverter:IListNoteItemParamConverter
    {
<<<<<<< Updated upstream
=======
        public IListNoteItemDao Dao = new ListNoteItemDao();

        public Entities.ListNoteItem Convert(ListNoteItemParam param)
        {
            Entities.ListNoteItem entity = new Entities.ListNoteItem()
            {
				Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,
                IsChecked=param.IsChecked,
                Text=param.Text
            };
            return entity;
        }

        public Entities.ListNoteItem Convert(ListNoteItemParam param, Entities.ListNoteItem oldEntity)
        {
            Entities.ListNoteItem entity = null;

            if (oldEntity != null)
            {
                entity = oldEntity;
            }
            else
            {
                entity = new Entities.ListNoteItem();
            }

            entity.Name = param.Name;
            entity.Description = param.Description;
            entity.IsChecked = param.IsChecked;
            entity.Text = param.Text;

            return entity;
        }
>>>>>>> Stashed changes
    }
}
