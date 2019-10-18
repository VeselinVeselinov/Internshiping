using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.DataAccess.Dao.ListNoteItem;
using ToDoListStructure.Entities;

namespace ToDoListStructure.Business.Convertor.ListNoteItem
{
    class ListNoteItemParamConverter:IListNoteItemParamConverter
    {
        public ListNoteItemDao Dao { get; set; }

        public Entities.ListNoteItem Convert(ListNoteItemParam param)
        {
            throw new NotImplementedException();
        }
    }
}
