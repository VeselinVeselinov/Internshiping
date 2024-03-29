﻿using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.User;
using ToDoListStructure.Business.Processor.User;
using ToDoListStructure.Data.Common;

namespace ToDoListStructure.Presentation.Service.User
{
    class UserService:IUserService
    {
		public IUserProcessor Processor = new UserProcessor();

		public Response Create(UserParam param)
		{
			Response response = new Response();
			try
			{
				response.Text = "This entity has been added :" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(Processor.Create(param));
				response.Result = true;
			}
			catch
			{
				response.Text = "Unfortunately something went wrong. Are you sure that the entity you are trying to create doesn't already exist ?";
				response.Result = false;
			}
			return response;
		}

		public Response Create(List<UserParam> param)
		{
			Response response = new Response();
			try
			{
				response.Text = "These Data.Entity have been created on the system :" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(Processor.Create(param));
				response.Result = true;
			}
			catch
			{
				response.Text = "Unfortunately something went wrong. Are you sure that the Data.Entity you are trying to create don't already exist.";
				response.Result = false;
			}
			return response;
		}

		public Response DeleteByID(long id)
		{
			Response response = new Response();
			try
			{
				Processor.Delete(id);
				response.Text = $"Entity with id {id} was successfully removed from the system.";
				response.Result = true;
			}
			catch
			{
				response.Text = "Unfortunately something went wrong. Are you sure the entity you are trying to delete exists ?";
				response.Result = false;
			}
			return response;
		}

		public Response Delte(List<long> idList)
		{
			Response response = new Response();
			try
			{
				Processor.Delete(idList);
				string ids = null;
				idList.ForEach(id => ids += id.ToString() + " ");
				response.Text = $"Data.Entity {ids}were successfully removed from the system.";
				response.Result = true;
			}
			catch
			{
				response.Text = "Unfortunately something went wrong. Are you sure all the Data.Entity you are trying to delete exist ?";
				response.Result = false;
			}
			return response;
		}

		public Response FindByPK(long id)
		{
			Response response = new Response();
			try
			{
				Processor.Find(id);
				response.Text = "Entity with this PK has been found :" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(Processor.Find(id));
				response.Result = true;
			}
			catch
			{
				response.Text = "An entity with this id does not exist.";
				response.Result = false;
			}
			return response;
		}

		public Response ListAll()
		{
			Response response = new Response();
			try
			{
				Processor.Find();
				response.Text = "Here is a list of all the Data.Entity on the system :" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(Processor.Find());
				response.Result = true;
			}
			catch
			{
				response.Text = "Unfortunately something went wrong. Try again later. :)";
				response.Result = false;
			}
			return response;
		}

		public Response Update(long id, UserParam param)
		{
			Response response = new Response();
			try
			{
				Processor.Update(id, param);
				response.Text = "The entity has been updated.";
				response.Result = true;
			}
			catch
			{
				response.Text = "The command was unable to execute. Are you sure the entity you want to update exists.";
				response.Result = false;
			}
			return response;
		}

		public Response Update(List<UserParam> param)
		{
			Response response = new Response();
			try
			{
				Processor.Update(param);
				response.Text = "Data.Entity have been updated.";
				response.Result = true;
			}
			catch
			{
				response.Text = "The command was unable to execute. Are you sure the Data.Entity you want to update exist.";
				response.Result = false;
			}
			return response;
		}

		public void ValidateParameters(UserParam param)
		{
			throw new NotImplementedException();
		}

		public void ValidateParameters(List<UserParam> param)
		{
			throw new NotImplementedException();
		}
	}
}
