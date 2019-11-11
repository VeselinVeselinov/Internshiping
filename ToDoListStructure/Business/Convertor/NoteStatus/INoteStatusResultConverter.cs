using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;

namespace ToDoListStructure.Business.Convertor.NoteStatus
{
    interface INoteStatusResultConverter:IBaseResultConverter<Data.Entity.NoteStatus,NoteStatusResult>
    {
        NoteStatusResult Convert(ToDoListStructure.Data.Entity.NoteStatus param);
    }
}
