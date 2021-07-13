﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class Author
    {

        public int id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public List<Book> Books { get; set; }
    }
}