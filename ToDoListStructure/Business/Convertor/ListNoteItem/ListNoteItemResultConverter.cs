using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;
using ToDoListStructure.Data.Entity;

namespace ToDoListStructure.Business.Convertor.ListNoteItem
{
    class ListNoteItemResultConverter : BaseResultConverter<Data.Entity.ListNoteItem,ListNoteItemResult>,IListNoteItemResultConverter
    {
		public override ListNoteItemResult ConvertSpecific(Data.Entity.ListNoteItem entity, ListNoteItemResult result)
		{
			throw new NotImplementedException();
		}

		public ListNoteItemResult Convert(Data.Entity.ListNoteItem param)
        {
			ListNoteItemResult result = ConvertStandart(param, new ListNoteItemResult());
			return result;
        }
	}
}
