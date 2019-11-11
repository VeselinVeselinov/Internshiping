using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.NoteStatus;

namespace ToDoListStructure.Business.Processor.NoteStatus
{
    interface INoteStatusProcessor
    {
		NoteStatusResult Create(NoteStatusParam param);

		List<NoteStatusResult> Create(List<NoteStatusParam> param);

		void Update(long id, NoteStatusParam param);

		void Update(List<NoteStatusParam> param);

		void Delete(long id);

		void Delete(List<long> idList);

		NoteStatusResult Find(long id);

		List<NoteStatusResult> Find();

		NoteStatusResult FindByCode(string code);

		List<NoteStatusResult> FindByName(string name);

		List<NoteStatusResult> FindByAttribute(string att, string value);
	}
}
