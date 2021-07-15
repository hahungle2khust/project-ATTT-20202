using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegisAndLogin.Models
{
    public class UserLogin
    {
        [Display(Name ="Username:")]
        [Required(AllowEmptyStrings =false, ErrorMessage ="Username required!")]
        public string Username { get; set; }

        [Display(Name ="Answer the question: 1")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Answer required!")]
        public string Answer1 { get; set; }

        [Display(Name = "Answer the question: 2")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Answer required!")]
        public string Answer2 { get; set; }

        [Display(Name = "Answer the question: 3")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Answer required!")]
        public string Answer3 { get; set; }
    }
}