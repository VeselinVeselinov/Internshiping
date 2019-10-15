using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.DataAccess.Dao.ShareStatus;
using ToDoListStructure.Entities;

namespace ToDoListStructure.Business.Convertor.ShareStatus
{
    class ShareStatusParamConverter:IShareStatusParamConverter
    {
        public ShareStatusDao Dao { get; set; }

        public Entities.ShareStatus Convert(ShareStatusParam param)
        {
            throw new NotImplementedException();
        }
    }
}
