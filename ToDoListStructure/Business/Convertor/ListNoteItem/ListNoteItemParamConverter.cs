using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;
using ToDoListStructure.DataAccess.Dao.ListNoteItem;
using ToDoListStructure.Data.Entity;

namespace ToDoListStructure.Business.Convertor.ListNoteItem
{
    class ListNoteItemParamConverter:BaseParamConverter<ListNoteItemParam,Data.Entity.ListNoteItem>,IListNoteItemParamConverter
    {
		public override Data.Entity.ListNoteItem ConvertSpecific(ListNoteItemParam param, Data.Entity.ListNoteItem entity)
		{
			throw new NotImplementedException();
		}

		public Data.Entity.ListNoteItem Convert(ListNoteItemParam param, Data.Entity.ListNoteItem oldEntity)
        {
			Data.Entity.ListNoteItem entity = null;

			if (oldEntity != null)
			{
				entity = oldEntity;
			}
			else
			{
				entity = new Data.Entity.ListNoteItem()
				{
					Id=param.Id,
					Code=param.Code
				};
			}

			entity.Name = param.Name;
			entity.Description = param.Description;
			entity.IsChecked = param.IsChecked;
			entity.Text = param.Text;

			return entity;
		}
	}
}
