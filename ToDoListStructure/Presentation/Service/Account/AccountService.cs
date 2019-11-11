using System;
using System.Collections.Generic;
using System.Text;
using ToDoListStructure.Business.Convertor.Account;
using ToDoListStructure.Business.Processor.Account;
using ToDoListStructure.Data.Common;
using ToDoListStructure.Presentation.JsonConverter;

namespace ToDoListStructure.Presentation.Service.Account
{
    class AccountService:IAccountService
    {
		public IAccountProcessor Processor = new AccountProcessor();

		public Response Create(AccountParam param)
		{
			Response response = new Response();
			try
			{
				response.Text = "This account has been added :" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(Processor.Create(param));
				response.Result = true;
			}
			catch (InvalidOperationException)
			{
				response.Text = "The user and/or status you've entered to the account do not exist in the system.";
			}
			catch (Exception)
			{
				response.Text = "Unfortunately something went wrong. Are you sure that the entity you are trying to create doesn't already exist ?";
				response.Result = false;
			}
			return response;
		}

		public Response Create(List<AccountParam> param)
		{
			Response response = new Response();
			try
			{
				response.Text = "These entities have been created on the system :" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(Processor.Create(param));
				response.Result = true;
			}
			catch (InvalidOperationException)
			{
				response.Text = "The user and/or status you've entered to the account do not exist in the system.";
				response.Result = false;
			}
			catch
			{
				response.Text = "Unfortunately something went wrong. Are you sure that the entities you are trying to create don't already exist.";
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
			catch(NullReferenceException e)
			{
				response.Text = "Unfortunately something went wrong. Are you sure the entity you are trying to delete exists ?"+ e.GetType();
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

		public Response FindByAttribute(string att, string value)
		{
			Response response = new Response();
			try
			{
				response.Text = $"Attribute: {att} with value: {value} has been found :" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(Processor.FindByAttribute(att, value));
				response.Result = false;
			}
			catch
			{
				response.Text = "Are you sure the attribute you are looking for exists ?";
				response.Result = false;
			}
			return response;
		}

		public Response FindByCode(string code)
		{
			Response response = new Response();
			try
			{
				response.Text = "Entity with this code has been found :" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(Processor.FindByCode(code));
				response.Result = true;
			}
			catch
			{

				response.Text = $"There is no entity with the corresponding code: {code}.";
				response.Result = false;
			}
			return response;
		}

		public Response FindByName(string name)
		{
			Response response = new Response();
			try
			{
				response.Text = "The name you are looking for has been found :" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(Processor.FindByName(name));
				response.Result = true;
			}
			catch
			{
				response.Text = $"The name you are looking for ({name}) does not exist in the system.";
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
				response.Text = "Account with this PK has been found :" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(Processor.Find(id));
				response.Result = true;
			}
			catch(InvalidOperationException)
			{
				response.Text = $"An account with id: {id} does not exist.";
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
				response.Text = "Here is a list of all the entities on the system :" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(Processor.Find());
				response.Result = true;
			}
			catch
			{
				response.Text = "Unfortunately something went wrong. Try again later. :)";
				response.Result = false;
			}
			return response;
		}

		public Response Update(long id, AccountParam param)
		{
			Response response = new Response();
			try
			{
				Processor.Update(id, param);
				response.Text = "The entity has been updated.";
				response.Result = true;
			}
			catch (InvalidOperationException)
			{
				response.Text = $"Entity status with id: {param.StatusId} (or user id: {param.UserId}) does not exist, therefore the update cannot execute.";
				response.Result = false;
			}
			catch (NullReferenceException)
			{
				response.Text = $"Entity with id: {id} does not exist, therefore there is nothing to update.";
				response.Result = false;
			}
			return response;
		}

		public Response Update(List<AccountParam> param)
		{
			Response response = new Response();
			try
			{
				Processor.Update(param);
				response.Text = "All the entities you have requested have been updated.";
				response.Result = true;
			}
			catch (InvalidOperationException)
			{
				response.Text = "The entities you are requesting to update have no corresponding users/statuses in the system.";
				response.Result = false;
			}
			catch (NullReferenceException e)
			{
				response.Text = $"Entities with ids: {e.Message} do not exist in the system and therefore can not be updated.";
				response.Result = false;
			}
			return response;
		}

		public void ValidateParameters(AccountParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<AccountParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
