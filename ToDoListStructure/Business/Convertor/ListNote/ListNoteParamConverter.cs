using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.DataAccess.Dao.ListNote;
using ToDoListStructure.Entities;

namespace ToDoListStructure.Business.Convertor.ListNote
{
    class ListNoteParamConverter:IListNoteParamConverter
    {
        public ListNoteDao Dao { get; set; }

        public Entities.ListNote Convert(ListNoteParam param)
        {
            throw new NotImplementedException();
        }
    }
}
