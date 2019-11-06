using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Business.Convertor.Common
{
	class BaseParamConverter<Tin, Tout> : IBaseParamConverter<Tin, Tout>
	{
		public Tout ConvertSpecific(Tin param, Tout entity)
		{
			throw new NotImplementedException();
		}

		public Tout ConvertStandart(Tin param, Tout entity)
		{
			throw new NotImplementedException();
		}
	}
}
