using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegisAndLogin.Models.Extended
{
    [MetadataType(typeof(UserMetaData))]
    public partial class user
    {
    }
    public class UserMetaData
    {
        [Display(Name = "Username")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Username required")]
        public string username { get; set; }

        [Display(Name ="first name")]
        [Required(AllowEmptyStrings =false, ErrorMessage ="First name required")]
        public string firstname { get; set; }

        [Display(Name = "last name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Last name required")]
        public string lastname { get; set; }

        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode =true, DataFormatString ="{0:MM/dd/yyyy}")]
        public DateTime dob { get; set; }

        [Display(Name = "email")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "email required")]
        public string gentle { get; set; }

        //Chọn topic 1, câu hỏi 1 và trả lời câu hỏi 1
        [Display(Name = "Choose your topics 1")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please choose!")]
        public string topics1 { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "answer the question!")]
        [Display(Name = "Answer the question!")]
        public string question1 { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "answer the question!")]
        [Display(Name = "Your answer")]
        public string answer1 { get; set; }

        //Chọn topic 2, câu hỏi 2 và trả lời câu hỏi 2
        [Display(Name = "Choose your topics 2")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please choose!")]
        public string topics2 { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "answer the question!")]
        [Display(Name = "Answer the question!")]
        public string question2 { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "answer the question!")]
        [Display(Name = "Your answer")]
        public string answer2 { get; set; }

        //Chọn topic 3, câu hỏi 3 và trả lời câu hỏi 3
        [Display(Name = "Choose your topics 3")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please choose!")]
        public string topics3 { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "answer the question!")]
        [Display(Name = "Answer the question!")]
        public string question3 { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "answer the question!")]
        [Display(Name = "Your answer")]
        public string answer3 { get; set; }
    }
}