using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.DataAccess.Dao.ImageNote;
using ToDoListStructure.Data.Entity;

namespace ToDoListStructure.Business.Convertor.ImageNote
{
    class ImageNoteParamConverter:IImageNoteParamConverter
    {
        public IImageNoteDao Dao { get; set; }

        public Data.Entity.ImageNote Convert(ImageNoteParam param)
        {
            throw new NotImplementedException();
        }
    }
}
