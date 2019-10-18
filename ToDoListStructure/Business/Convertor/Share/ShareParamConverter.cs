using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.DataAccess.Dao.Share;
using ToDoListStructure.Entities;

namespace ToDoListStructure.Business.Convertor.Share
{
    class ShareParamConverter:IShareParamConverter
    {
        public ShareDao Dao { get; set; }

        public Entities.Share Convert(ShareParam param)
        {
            throw new NotImplementedException();
        }
    }
}
