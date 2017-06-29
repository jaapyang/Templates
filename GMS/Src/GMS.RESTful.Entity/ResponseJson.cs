using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GMS.RESTful.Entity
{
    public class ResponseJson<T>
    {
        public ResponseJson()
        {
            Status = true;
        }

        public bool Status { get; set; }

        public String Message { get; set; }

        public T Data { get; set; }
    }

    public class ResponseJson
    {
        public ResponseJson()
        {
            Status = true;
        }

        public bool Status { get; set; }

        public String Message { get; set; }

        public object Data { get; set; }
        
    }
}
