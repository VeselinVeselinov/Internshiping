using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.DataAccess.Dao.Share;

namespace ToDoListStructure.Business.Convertor.Share
{
    class ShareParamConverter:IShareParamConverter
    {
        public ShareDao Dao { get; set; }
    }
}
