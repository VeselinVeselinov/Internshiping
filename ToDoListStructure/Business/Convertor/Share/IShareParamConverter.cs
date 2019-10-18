using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.Share
{
    interface IShareParamConverter
    {
        ToDoListStructure.Entities.Share Convert(ShareParam param);
    }
}
