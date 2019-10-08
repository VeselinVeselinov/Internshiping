using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.DataAccess.Dao.ListNote;

namespace ToDoListStructure.Business.Convertor.ListNote
{
    class ListNoteParamConverter:IListNoteParamConverter
    {
        public ListNoteDao Dao { get; set; }
    }
}
