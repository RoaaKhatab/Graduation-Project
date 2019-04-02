using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace SchoolGuide3.Models
{
    public class Schools
    {
        [Key]

        public int Sc_id { get; set; }

        [Required(ErrorMessage = "School Name Is required")]
        public string  Sc_Name { get; set; }

        [Required(ErrorMessage = "Details are required")]       
        public string Sc_Details { get; set; }

        public string Sc_Facebook { get; set; }

        public string Sc_Twitter { get; set; }

        public string Sc_instagram { get; set; }

        public String Sc_Image { get; set; }

        public String Sc_Category { get; set; }
        public String Sc_Fees { get; set; }


        [Required(ErrorMessage = "Location is required")]
        public string Sc_Location{ get; set; }

        [Required(ErrorMessage = "Phone is required")]
        public int     Sc_phone1 { get; set; }
        
        public int Sc_phone2 { get; set; }


        public int Sc_phone3 { get; set; }


    }
}