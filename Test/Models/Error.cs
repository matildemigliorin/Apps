 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class Error
    {
        public int ID { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Message {get; set;}
        public string StackTrace { get; set; }
    }
}