using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GMS.RESTful.Entity
{
    public class BindRequest
    {     
          
        /// <summary>
        /// 绑定QQ或者微信返回的openid
        /// </summary>
        public String OpenID { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        public String NickName { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public int Sex { get; set; }     
        
        /// <summary>
        /// 头像地址
        /// </summary>
        public String Avatar { get; set; }


    }
}
