using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExampleSite.Models
{
    public class ContactUsModel
    {
        [Display(Name = "first name")]
        [Required(ErrorMessage = "First name is required")]
        [StringLength(60, MinimumLength = 3)]
        public string FirstName { get; set; }

        [Display(Name = "email address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Display(Name = "email subject")]
        [Required(ErrorMessage = "Email subject is required")]
        [StringLength(100, MinimumLength = 3)]
        public string Subject { get; set; }

        [Display(Name = "email message")]
        [Required(ErrorMessage = "Email message is required")]
        [StringLength(240, MinimumLength = 3)]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }
    }
}