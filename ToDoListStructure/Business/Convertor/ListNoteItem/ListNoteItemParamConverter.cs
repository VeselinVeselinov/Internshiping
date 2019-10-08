using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.DataAccess.Dao.ListNoteItem;

namespace ToDoListStructure.Business.Convertor.ListNoteItem
{
    class ListNoteItemParamConverter:IListNoteItemParamConverter
    {
        public ListNoteItemDao Dao { get; set; }
    }
}
