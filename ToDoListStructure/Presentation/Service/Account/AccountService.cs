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
        public Response Response { get; set; }

        public IAccountProcessor Processor { get; set; }

        public Response Create(AccountParam param)
        {
            try
            {
                Response.Text = "This account has been added" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(Processor.Create(param));
                Response.Result = true;
            }
            catch
            {
                Response.Text = "Unfortunately something went wrong. Try again later. :)";
                Response.Result = false;
            }
            return Response;
        }

        public Response Create(List<AccountParam> param)
        {
            Response = new Response();
            try
            {
                Response.Text = JsonConverter.JsonConverter.ObjToJson(Processor.Create(param));
                Response.Result = true;
            }
            catch
            {
                Response.Text = "Unfortunately something went wrong. Try again later. :)";
                Response.Result = false;
            }
            return Response;
        }

        public Response DeleteByID(long id)
        {
            try
            {
                Processor.Delete(id);
                Response.Text = "Entity was successfully removed from the system.";
                Response.Result = true;
            }
            catch
            {
                Response.Text = "Unfortunately something went wrong. Try again later. :)";
                Response.Result = false;
            }
            return Response;
        }

        public Response Delte(List<long> idList)
        {
            try
            {
                Processor.Delete(idList);
                Response.Text = "Entities were successfully removed from the system.";
                Response.Result = true;
            }
            catch
            {
                Response.Text = "Unfortunately something went wrong. Try again later. :)";
                Response.Result = false;
            }
            return Response;
        }

        public Response FindByPK(long id)
        {
            try
            {
                Processor.Find(id);
                Response.Text = "Account with this PK has been found"+Environment.NewLine+JsonConverter.JsonConverter.ObjToJson(Processor.Find(id));
                Response.Result = true;
            }
            catch
            {
                Response.Text = "An account with this id does not exist";
                Response.Result = false;
            }
            return Response;
        }

        public Response ListAll()
        {
            try
            {
                Processor.Find();
                Response.Text = JsonConverter.JsonConverter.ObjToJson(Processor.Find());
                Response.Result = true;
            }
            catch
            {
                Response.Text = "Unfortunately something went wrong. Try again later. :)";
                Response.Result = false;
            }
            return Response;
        }

        public Response Update(long id, AccountParam param)
        {
            try
            {
                Processor.Update(id,param);
                Response.Text = "The entity has been updated.";
                Response.Result = true;
            }
            catch
            {
                Response.Text = "Unfortunately something went wrong. Try again later. :)";
                Response.Result = false;
            }
            return Response;
        }

        public Response Update(List<AccountParam> param)
        {
            try
            {
                Processor.Update(param);
                Response.Text = "Entities have been updated.";
                Response.Result = true;
            }
            catch
            {
                Response.Text = "Unfortunately something went wrong. Try again later. :)";
                Response.Result = false;
            }
            return Response;
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
