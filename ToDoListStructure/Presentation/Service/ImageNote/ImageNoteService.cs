using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Processor.ImageNote;

namespace ToDoListStructure.Presentation.Service.ImageNote
{
    class ImageNoteService:IImageNoteService
    {
        public ImageNoteProcessor Processor { get; set; }
    }
}
