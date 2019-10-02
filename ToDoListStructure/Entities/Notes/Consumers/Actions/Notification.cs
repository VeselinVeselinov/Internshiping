using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Entities.Notes.Consumers.Actions
{
    class Notification:NamedPersistent
    {
        public string NotificationMessage { get; set; }
        public Alert NoteAlert { get; set; }
    }
}
