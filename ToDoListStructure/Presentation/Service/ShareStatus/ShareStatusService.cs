using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Processor.ShareStaus;

namespace ToDoListStructure.Presentation.Service.ShareStatus
{
    class ShareStatusService:IShareStatusService
    {
        public ShareStatusProcessor Processor { get; set; }
    }
}
