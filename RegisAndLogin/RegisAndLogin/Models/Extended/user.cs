using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegisAndLogin.Models.Extended
{
    [MetadataType(typeof(UserMetaData))]
    public partial class User
    {
    }
    public class UserMetaData
    {
        [Display(Name = "Username")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Username required")]
        public string Username { get; set; }

        [Display(Name ="first name")]
        [Required(AllowEmptyStrings =false, ErrorMessage ="First name required")]
        public string Firstname { get; set; }

        [Display(Name = "last name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Last name required")]
        public string Lastname { get; set; }

        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString ="{0:MM/dd/yyyy}")]
        public DateTime Dob { get; set; }

        [Display(Name = "last name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Last name required")]
        public string Gentle { get; set; }

        [Display(Name = "email")]
        [DataType(DataType.EmailAddress)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "email required")]
        public string Email { get; set; }

        //Chọn topic 1, câu hỏi 1 và trả lời câu hỏi 1
        [Display(Name = "Choose your topics 1")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please choose!")]
        public string Topics1 { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "answer the question!")]
        [Display(Name = "Answer the question!")]
        public string Question1 { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "answer the question!")]
        [Display(Name = "Your answer")]
        public string Answer1 { get; set; }

        //Chọn topic 2, câu hỏi 2 và trả lời câu hỏi 2
        [Display(Name = "Choose your topics 2")]
        [Required(AllowEmptyStrings = true, ErrorMessage = "Please choose!")]
        public string Topics2 { get; set; }

        [Required(AllowEmptyStrings = true, ErrorMessage = "answer the question!")]
        [Display(Name = "Answer the question!")]
        public string Question2 { get; set; }

        [Required(AllowEmptyStrings = true, ErrorMessage = "answer the question!")]
        [Display(Name = "Your answer")]
        public string Answer2 { get; set; }

        //Chọn topic 3, câu hỏi 3 và trả lời câu hỏi 3
        [Display(Name = "Choose your topics 3")]
        [Required(AllowEmptyStrings = true, ErrorMessage = "Please choose!")]
        public string Topics3 { get; set; }

        [Required(AllowEmptyStrings = true, ErrorMessage = "answer the question!")]
        [Display(Name = "Answer the question!")]
        public string Question3 { get; set; }

        [Required(AllowEmptyStrings = true, ErrorMessage = "answer the question!")]
        [Display(Name = "Your answer")]
        public string Answer3 { get; set; }
    }
}