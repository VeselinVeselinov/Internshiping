﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Processor.Category
{
    interface ICategoryProcessor
    {
<<<<<<< Updated upstream
=======
        CategoryResult Create(CategoryParam param);

        List<CategoryResult> Create(List<CategoryParam> param);

        void Update(long id, CategoryParam param);

        void Update(List<CategoryParam> param);

        void Delete(long id);

        void Delete(List<long> idList);

        CategoryResult Find(long id);

        List<CategoryResult> Find();

        CategoryResult FindByCode(string code);

        List<CategoryResult> FindByName(string name);
>>>>>>> Stashed changes
    }
}
