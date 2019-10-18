using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.ShareStatus
{
    interface IShareStatusParamConverter
    {
        ToDoListStructure.Entities.ShareStatus Convert(ShareStatusParam param);
    }
}
