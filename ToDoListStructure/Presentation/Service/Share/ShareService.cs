using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Processor.Share;

namespace ToDoListStructure.Presentation.Service.Share
{
    class ShareService:IShareService
    {
        public ShareProcessor Processor { get; set; }
    }
}
