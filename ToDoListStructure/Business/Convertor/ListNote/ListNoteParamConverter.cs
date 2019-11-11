using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.DataAccess.Dao.ListNote;
using ToDoListStructure.Data.Entity;

namespace ToDoListStructure.Business.Convertor.ListNote
{
    class ListNoteParamConverter:IListNoteParamConverter
    {
        public IListNoteDao Dao { get; set; }

        public Data.Entity.ListNote Convert(ListNoteParam param)
        {
            throw new NotImplementedException();
        }
    }
}
