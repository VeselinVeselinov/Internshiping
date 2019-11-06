using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListStructure.Presentation.Service.AccountStatus
{
    class AccountStatusService:IAccountStatusService
    {
<<<<<<< Updated upstream
=======
        public IAccountStatusProcessor Processor = new AccountStatusProcessor();

        public Response Create(AccountStatusParam param)
        {
            Response response = new Response();
            try
            {
                response.Text = "This account has been added :" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(Processor.Create(param));
                response.Result = true;
            }
            catch
            {
                response.Text = "Unfortunately something went wrong. Are you sure that the entity you are trying to create doesn't already exist ?";
                response.Result = false;
            }
            return response;
        }

        public Response Create(List<AccountStatusParam> param)
        {
            Response response = new Response();
            try
            {
                response.Text = "These entities have been created on the system :" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(Processor.Create(param));
                response.Result = true;
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
                response.Text = $"Entities {ids}were successfully removed from the system.";
                response.Result = true;
            }
            catch
            {
                response.Text = "Unfortunately something went wrong. Are you sure all the entities you are trying to delete exist ?";
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

                response.Text = "There is no entity with the corresponding code.";
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
                response.Text = "The name you are looking for does not exist in the system.";
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
            catch
            {
                response.Text = "An account with this id does not exist.";
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

        public Response Update(long id, AccountStatusParam param)
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

        public Response Update(List<AccountStatusParam> param)
        {
            Response response = new Response();
            try
            {
                Processor.Update(param);
                response.Text = "Entities have been updated.";
                response.Result = true;
            }
            catch
            {
                response.Text = "The command was unable to execute. Are you sure the entities you want to update exist.";
                response.Result = false;
            }
            return response;
        }

        public void ValidateParameters(AccountStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<AccountStatusParam> param)
        {
            throw new NotImplementedException();
        }
>>>>>>> Stashed changes
    }
}
