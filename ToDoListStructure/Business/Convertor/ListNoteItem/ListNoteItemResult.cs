﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.ListNoteItem
{
    class ListNoteItemResult:BaseResultNamed
    {
        public bool IsChecked { get; set; }

        public string Text { get; set; }
    }
}
