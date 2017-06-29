using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Web;
using System.Text;
using System.Xml;
using GMS.Account.Contract;
using GMS.Web;

namespace AR.WCFServer.Authorization
{
    public class MyServiceAuthorizationManager : ServiceAuthorizationManager
    {
        public IAccountService AccountService
        {
            get
            {
                return ServiceContext.Current.AccountService;
            }
        }

        protected override bool CheckAccessCore(OperationContext operationContext)
        {
            //var ctx = WebOperationContext.Current;
            //String [] uncheckedMethods =new String[]{ "User/Register", "User/Login", "OAuth/Token" };
            //if (uncheckedMethods.Contains(ctx.IncomingRequest.UriTemplateMatch.Template.ToString()))
            //    return true;
            //var authToken = ctx.IncomingRequest.Headers[HttpRequestHeader.Authorization];
            
            //if (string.IsNullOrEmpty(authToken) || !AccountService.CheckAuthorization(authToken))
            //{
            //    ctx.OutgoingResponse.StatusCode = HttpStatusCode.MethodNotAllowed;
            //    return false;
            //}
            return true;
        }        
    }
}