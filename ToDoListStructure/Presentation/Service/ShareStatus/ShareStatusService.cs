using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.ShareStatus;
using ToDoListStructure.Business.Processor.ShareStaus;
using ToDoListStructure.Data.Common;

namespace ToDoListStructure.Presentation.Service.ShareStatus
{
    class ShareStatusService:IShareStatusService
    {
        public ShareStatusProcessor Processor { get; set; }

        public Response Create(ShareStatusParam param)
        {
            throw new NotImplementedException();
        }

        public Response Create(List<ShareStatusParam> param)
        {
            throw new NotImplementedException();
        }

        public Response DeleteByID(long id)
        {
            throw new NotImplementedException();
        }

        public Response Delte(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public Response FindByPK(long id)
        {
            throw new NotImplementedException();
        }

        public Response ListAll()
        {
            throw new NotImplementedException();
        }

        public Response Update(long id, ShareStatusParam param)
        {
            throw new NotImplementedException();
        }

        public Response Update(List<ShareStatusParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(ShareStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<ShareStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
