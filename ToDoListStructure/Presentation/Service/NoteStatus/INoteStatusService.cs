using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.NoteStatus;
using ToDoListStructure.Data.Common;

namespace ToDoListStructure.Presentation.Service.NoteStatus
{
    interface INoteStatusService
    {
		Response FindByPK(long id);

		Response ListAll();

		Response FindByCode(string code);

		Response FindByName(string name);

		Response FindByAttribute(string att, string value);

		Response Create(NoteStatusParam param);

		Response Create(List<NoteStatusParam> param);

		Response Update(long id, NoteStatusParam param);

		Response Update(List<NoteStatusParam> param);

		Response DeleteByID(long id);

		Response Delte(List<long> idList);

		void ValidateParameters(NoteStatusParam param);

		void ValidateParameters(List<NoteStatusParam> param);
	}
}
