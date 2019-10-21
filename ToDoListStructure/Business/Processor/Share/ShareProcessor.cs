using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Share;
using ToDoListStructure.DataAccess.Dao.Share;

namespace ToDoListStructure.Business.Processor.Share
{
    class ShareProcessor:IShareProcessor
    {
        public IShareDao Dao { get; set; }

        public IShareParamConverter ParamConverter { get; set; }

        public IShareResultConverter ResultConverter { get; set; }

        public ShareResult Create(ShareParam param)
        {
            throw new NotImplementedException();
        }

        public List<ShareResult> Create(List<ShareParam> param)
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

        public ShareResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<ShareResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, ShareParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<ShareParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
