using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.ShareStatus;
using ToDoListStructure.DataAccess.Dao.ShareStatus;

namespace ToDoListStructure.Business.Processor.ShareStaus
{
    class ShareStatusProcessor:IShareStatusProcessor
    {
        public ShareStatusDao Dao { get; set; }

        public ShareStatusParamConverter ParamConverter { get; set; }

        public ShareStatusResultConverter ResultConverter { get; set; }
    }
}
