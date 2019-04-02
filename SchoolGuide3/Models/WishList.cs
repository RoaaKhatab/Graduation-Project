using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SchoolGuide3.Models
{
    public class WishList
    {
        [Key]

        public string SchoolPage { get; set; }
    }
}