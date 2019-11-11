using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Common;

namespace ToDoListStructure.Business.Convertor.AlertStatus
{
    class AlertStatusResultConverter : BaseResultConverter<Data.Entity.AlertStatus, AlertStatusResult>,IAlertStatusResultConverter
    {
		public override AlertStatusResult ConvertSpecific(Data.Entity.AlertStatus entity, AlertStatusResult result)
		{
			throw new NotImplementedException();
		}

		public AlertStatusResult Convert(Data.Entity.AlertStatus param)
        {
			AlertStatusResult result = ConvertStandart(param, new AlertStatusResult());
			return result;
        }
	}
}
