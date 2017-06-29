using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GMS.RESTful.Entity
{
    public class LoginResponse
    {       

        public String LoginName { get; set; }

        public int UserID { get; set; }   
        
        public String Token { get; set; }    

    }
}
