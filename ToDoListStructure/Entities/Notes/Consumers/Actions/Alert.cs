using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Entities.Notes.Consumers.Actions
{
    class Alert:NamedPersistent
    {
        public Note NoteWithReminder { get; set; }
        public DateTime ReminderTime { get; set; }
    }
}
