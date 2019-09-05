﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace web2.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        public int Age { get; set; }
        public Standard standard { get; set; }
    }

    public class Standard
    {
        public int StandardId { get; set; }
        public string StandardName { get; set; }
    }
}