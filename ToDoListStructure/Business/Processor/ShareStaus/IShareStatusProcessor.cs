using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.ShareStatus;

namespace ToDoListStructure.Business.Processor.ShareStaus
{
    interface IShareStatusProcessor
    {
        ShareStatusResult Create(ShareStatusParam param);

        List<ShareStatusResult> Create(List<ShareStatusParam> param);

        void Update(long id, ShareStatusParam param);

        void Update(List<ShareStatusParam> param);

        void Delete(long id);

        void Delete(List<long> idList);

        ShareStatusResult Find(long id);

        List<ShareStatusResult> Find();
    }
}
