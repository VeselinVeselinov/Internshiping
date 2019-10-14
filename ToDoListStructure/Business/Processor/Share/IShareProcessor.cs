using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Share;

namespace ToDoListStructure.Business.Processor.Share
{
    interface IShareProcessor
    {
        ShareResult Create(ShareParam param);

        List<ShareResult> Create(List<ShareParam> param);

        void Update(long id, ShareParam param);

        void Update(List<ShareParam> param);

        void Delete(long id);

        void Delete(List<long> idList);

        ShareResult Find(long id);

        List<ShareResult> Find();
    }
}
