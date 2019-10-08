using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.DataAccess.Dao.ImageNote;

namespace ToDoListStructure.Business.Convertor.ImageNote
{
    class ImageNoteParamConverter:IImageNoteParamConverter
    {
        public ImageNoteDao Dao { get; set; }
    }
}
