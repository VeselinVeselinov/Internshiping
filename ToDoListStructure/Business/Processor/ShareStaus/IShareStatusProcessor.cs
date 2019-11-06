using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Processor.ShareStaus
{
    interface IShareStatusProcessor
    {
<<<<<<< Updated upstream
=======
        ShareStatusResult Create(ShareStatusParam param);

        List<ShareStatusResult> Create(List<ShareStatusParam> param);

        void Update(long id, ShareStatusParam param);

        void Update(List<ShareStatusParam> param);

        void Delete(long id);

        void Delete(List<long> idList);

        ShareStatusResult Find(long id);

        List<ShareStatusResult> Find();

		ShareStatusResult FindByCode(string code);

		List<ShareStatusResult> FindByName(string name);
>>>>>>> Stashed changes
    }
}
