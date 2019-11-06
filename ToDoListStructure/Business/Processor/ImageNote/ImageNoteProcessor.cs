using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Processor.ImageNote
{
    class ImageNoteProcessor:IImageNoteProcessor
    {
<<<<<<< Updated upstream
=======
        public IImageNoteDao Dao = new ImageNoteDao();

        public IImageNoteParamConverter ParamConverter = new ImageNoteParamConverter();

        public IImageNoteResultConverter ResultConverter = new ImageNoteResultConverter();

        public ImageNoteResult Create(ImageNoteParam param)
        {
            Entities.ImageNote entity = ParamConverter.Convert(param);
            entity = Dao.Save(entity);
            return ResultConverter.Convert(entity);
        }

        public List<ImageNoteResult> Create(List<ImageNoteParam> param)
        {
            List<Entities.ImageNote> entities = new List<Entities.ImageNote>();
            foreach (var item in param)
            {
                entities.Add(ParamConverter.Convert(item));
            }
            Dao.Save(entities);
            List<ImageNoteResult> result = new List<ImageNoteResult>();
            entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));
            return result;
        }

        public void Delete(long id)
        {
            Dao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            Dao.Delete(idList);
        }

        public ImageNoteResult Find(long id)
        {
            Entities.ImageNote entity = Dao.Find(id);
            return ResultConverter.Convert(entity);
        }

        public List<ImageNoteResult> Find()
        {
            List<Entities.ImageNote> entities = Dao.Find();
            List<ImageNoteResult> results = new List<ImageNoteResult>();
            entities.ForEach(entity => results.Add(ResultConverter.Convert(entity)));
            return results;
        }

        public ImageNoteResult FindByCode(string code)
        {
            return ResultConverter.Convert(Dao.FindByCode(code));
        }

        public List<ImageNoteResult> FindByName(string name)
        {
            List<Entities.ImageNote> entities = Dao.FindByName(name);
            List<ImageNoteResult> result = new List<ImageNoteResult>();
            entities.ForEach(entity => result.Add(ResultConverter.Convert(entity)));
            return result;
        }

        public void Update(long id, ImageNoteParam param)
        {
            Entities.ImageNote oldEntity = Dao.Find(id);
            Entities.ImageNote newEntity = ParamConverter.Convert(param, oldEntity);
            Dao.Update(newEntity);
        }

        public void Update(List<ImageNoteParam> param)
        {
            List<Entities.ImageNote> entity = new List<Entities.ImageNote>();
            param.ForEach(item => entity.Add(ParamConverter.Convert(item)));
            Dao.Update(entity);
        }
>>>>>>> Stashed changes
    }
}
