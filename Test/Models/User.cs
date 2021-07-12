using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Test.Models
{
    [Table("Utenti")]
    public class User
    {
        public int ID { get; set;}
        [MaxLength(250)]
        /* [DisplayColumn("UserName")] questa proprieta fa si che sul db la colonna Name si chiami UserName*/
        public string Name { get; set; }
        [MaxLength(250)]
        public string Surname { get; set; }
        [MaxLength(180)]
        public string Email { get; set; }
        public bool Active { get; set; }

        public List<Book> Books { get; set; }
    }
}