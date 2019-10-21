using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.ShareStatus;
using ToDoListStructure.DataAccess.Dao.ShareStatus;

namespace ToDoListStructure.Business.Processor.ShareStaus
{
    class ShareStatusProcessor:IShareStatusProcessor
    {
        public IShareStatusDao Dao { get; set; }

        public IShareStatusParamConverter ParamConverter { get; set; }

        public IShareStatusResultConverter ResultConverter { get; set; }

        public ShareStatusResult Create(ShareStatusParam param)
        {
            throw new NotImplementedException();
        }

        public List<ShareStatusResult> Create(List<ShareStatusParam> param)
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

        public ShareStatusResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<ShareStatusResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, ShareStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<ShareStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
