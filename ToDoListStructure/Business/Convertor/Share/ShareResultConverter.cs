using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;
using ToDoListStructure.Data.Entity;

namespace ToDoListStructure.Business.Convertor.Share
{
    class ShareResultConverter : BaseResultConverter<Data.Entity.Share,ShareResult>,IShareResultConverter
    {
		public override ShareResult ConvertSpecific(Data.Entity.Share entity, ShareResult result)
		{
			result.OwnerId = entity.Owner.Id;
			result.OwnerName = entity.Owner.Name;
			result.ContributorId = entity.Contributor.Id;
			result.OwnerName = entity.Contributor.Name;
			result.NoteId = entity.Note.Id;
			result.NoteName = entity.Note.Name;
			result.StatusId = entity.Note.Id;
			result.StatusName = entity.Note.Name;

			return result;
		}

		public ShareResult Convert(Data.Entity.Share param)
        {
			ShareResult result = ConvertStandart(param, new ShareResult());
			return ConvertSpecific(param,result);
        }
	}
}
