using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class Book
    {
        public int ID {get; set;}

        [MaxLength(250)]
        public string Title { get; set; }
        [MaxLength(250)]
        public string Author { get; set; }
        [MaxLength(250)]
        public string ISBN { get; set; }
        public bool Available { get; set; }


        public User CurrentUser { get; set; }
    }
    
}