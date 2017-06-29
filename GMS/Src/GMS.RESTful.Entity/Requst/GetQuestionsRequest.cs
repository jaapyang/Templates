using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GMS.RESTful.Entity
{
    public class GetQuestionsRequest
    {
        public int UserID { get; set; }

        public int MissionID { get; set; }
    }
}
