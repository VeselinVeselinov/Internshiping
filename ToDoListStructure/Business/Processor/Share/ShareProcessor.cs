using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Share;
using ToDoListStructure.DataAccess.Dao.Share;

namespace ToDoListStructure.Business.Processor.Share
{
    class ShareProcessor:IShareProcessor
    {
        public ShareDao Dao { get; set; }

        public ShareParamConverter ParamConverter { get; set; }

        public ShareResultConverter ResultConverter { get; set; }

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
