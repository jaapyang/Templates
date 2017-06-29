using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GMS.RESTful.Entity
{
    public class RegisterRequest
    {       

        public String LoginName { get; set; }

        public String Password { get; set; }

        public int Sex { get; set; }        
        
    }
}
