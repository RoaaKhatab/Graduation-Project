using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SchoolGuide3.Models
{
    public class Users
    {
        [Key]

        public int UserID { get; set; }

        [Required(ErrorMessage = "First Name Is required")]
        [StringLength(255)]
        public String FirstName { get; set; }

        [Required(ErrorMessage = "Last Name Is required")]
        [StringLength(255)]
        public String LastName { get; set; }

        [Required(ErrorMessage = "Email Is required")]
        //[RegularExpression(@"^([\w\.\-]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage="Please Enter Valid E-mail.")]
        public String Email { get; set; }

        [Required(ErrorMessage = "UserName Is required")]
        [StringLength(255)]
        public String UserName { get; set; }


        public int Phone { get; set; }

        [Required(ErrorMessage = "Password Is required")]
        [DataType(DataType.Password)]
        public String Password { get; set; }

        [Compare("Password", ErrorMessage = "Please confirm your password")]
        [DataType(DataType.Password)]
        public String ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Age Is required")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Gender Is required")]
        public String Gender { get; set; }

        public String Address { get; set; }

        public String SSN { get; set; }
        public int Usertype { get; set; }

    }
}