using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.DataAccess.Dao.ShareStatus;

namespace ToDoListStructure.Business.Convertor.ShareStatus
{
    class ShareStatusParamConverter:IShareStatusParamConverter
    {
        public ShareStatusDao Dao { get; set; }
    }
}
