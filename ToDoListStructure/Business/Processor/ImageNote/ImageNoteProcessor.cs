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

        public ImageNoteResult Create(ImageNoteParam param)
        {
            throw new NotImplementedException();
        }

        public List<ImageNoteResult> Create(List<ImageNoteParam> param)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public void Delete(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public ImageNoteResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<ImageNoteResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, ImageNoteParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<ImageNoteParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
