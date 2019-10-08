using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.ImageNote;
using ToDoListStructure.DataAccess.Dao.ImageNote;

namespace ToDoListStructure.Business.Processor.ImageNote
{
    class ImageNoteProcessor:IImageNoteProcessor
    {
        public ImageNoteDao Dao { get; set; }

        public ImageNoteParamConverter ParamConverter { get; set; }

        public ImageNoteResultConverter ResultConverter { get; set; }
    }
}
