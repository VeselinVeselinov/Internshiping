using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;

namespace ToDoListStructure.Business.Convertor.NoteStatus
{
    interface INoteStatusParamConverter:IBaseParamConverter<NoteStatusParam,Data.Entity.NoteStatus>
    {
        ToDoListStructure.Data.Entity.NoteStatus Convert(NoteStatusParam param, Data.Entity.NoteStatus oldEntity);
    }
}
