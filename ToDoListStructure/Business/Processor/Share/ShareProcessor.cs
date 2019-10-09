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
    }
}
