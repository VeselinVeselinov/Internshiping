using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.DataAccess.Dao.ImageNote;
using ToDoListStructure.Entities;

namespace ToDoListStructure.Business.Convertor.ImageNote
{
    class ImageNoteParamConverter:IImageNoteParamConverter
    {
        public IImageNoteDao Dao { get; set; }

        public Entities.ImageNote Convert(ImageNoteParam param)
        {
            throw new NotImplementedException();
        }
    }
}
