using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Notification;
using ToDoListStructure.Data.Common;

namespace ToDoListStructure.Presentation.Service.Notification
{
    interface INotificationService
    {
		Response FindByPK(long id);

		Response ListAll();

		Response FindByCode(string code);

		Response FindByName(string name);

		Response FindByAttribute(string att, string value);

		Response Create(NotificationParam param);

		Response Create(List<NotificationParam> param);

		Response Update(long id, NotificationParam param);

		Response Update(List<NotificationParam> param);

		Response DeleteByID(long id);

		Response Delte(List<long> idList);

		void ValidateParameters(NotificationParam param);

		void ValidateParameters(List<NotificationParam> param);
	}
}
