using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GMS.RESTful.Entity
{
    public class GetMissionsRequest
    {
        public int UserID { get; set; }

        public int QuestionBankID { get; set; }
    }
}
