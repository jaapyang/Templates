using GMS.RESTful.Entity;
using GMS.Account.Contract;
using GMS.Core.Config;
using GMS.Framework.Contract;
using GMS.Framework.Utility;
using GMS.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Channels;
using System.ServiceModel.Web;
namespace AR.WCFServer
{
    [ServiceContract]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class UserSvc
    {
        public IAccountService AccountService
        {
            get
            {
                return ServiceContext.Current.AccountService;
            }
        }

        /// <summary>
        /// 注册用户
        /// </summary>
        /// <example>POST=>http://120.24.158.80:8089/UserSvc/User/Register</example>
        /// <param name="request">{"LoginName":"test","Password":"123456","Sex":2}</param>
        [OperationContract]
        [WebInvoke(UriTemplate = "User/Register", Method = "POST", RequestFormat = WebMessageFormat.Json)]
        public Message Register(RegisterRequest request)
        {
            ResponseJson<LoginResponse> json = new ResponseJson<LoginResponse>();
            WebOperationContext ctx = WebOperationContext.Current;

            try
            {         
                    throw new BusinessException("账户不存在！");                
            }
            catch (Exception ex)
            {
                json.Status = false;
                json.Message = ex.Message;
            }

            return ctx.CreateJsonResponse<ResponseJson<LoginResponse>>(json);
        }     

        /// <summary>
        /// 获取用户
        /// </summary>
        /// <example>GET=>http://120.24.158.80:8089/UserSvc/User/GetUser/1</example>
        /// <returns>{"Status":true,"Message":null,"Data":{"LoginName":"test","UserID":1},"ExtraData":null}</returns>
        [OperationContract]
        [WebGet(UriTemplate = "User/GetUser/{userID}",
            ResponseFormat = WebMessageFormat.Json)]
        public Message GetUser(String userID)
        {
            ResponseJson<GetUserResponse> json = new ResponseJson<GetUserResponse>();
            WebOperationContext ctx = WebOperationContext.Current;
            ctx.OutgoingResponse.StatusCode = HttpStatusCode.OK;

            try
            {
                var user = this.AccountService.GetUser(Convert.ToInt32(userID));
                if (user == null)
                    throw new BusinessException("用户不存在！");//The user is not exist!

                json.Data = new GetUserResponse()
                {
                    LoginName = user.LoginName,
                    UserID = user.ID
                };

            }
            catch (Exception ex)
            {
                json.Status = false;
                json.Message = ex.Message;
            }

            return ctx.CreateJsonResponse<ResponseJson<GetUserResponse>>(json);
        }
               
        /// <summary>
        /// 用户排名记录
        /// </summary>             
        /// <example>GET=>http://120.24.158.80:8089/UserSvc/User/GetUserRanking</example>
        /// <param name="request">tabFlag:0=》对应一周内的排名，1=》对应总排名</param>
        /// <returns></returns>   
        [OperationContract]
        [WebGet(UriTemplate = "User/GetUserRanking/{userID}/{tabFlag}")]
        public Message GetUserRanking(String userID, String tabFlag)
        {
            ResponseJson<GetUserRankingResponse> json = new ResponseJson<GetUserRankingResponse>();
            WebOperationContext ctx = WebOperationContext.Current;
            ctx.OutgoingResponse.StatusCode = HttpStatusCode.OK;
            
            try
            {                
                
            }
            catch (Exception ex)
            {
                json.Status = false;
                json.Message = ex.Message;
            }

            return ctx.CreateJsonResponse<ResponseJson<GetUserRankingResponse>>(json);
        }
    }
}